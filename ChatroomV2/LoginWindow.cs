using System.Windows.Forms;
using System.Drawing;
using System;
using System.IO;

namespace ChatroomV2
{
    public partial class LoginWindow : Form
    {
        ChatWindow chatWindow;
        
        bool registerNewAccount = false;

        public LoginWindow(ChatWindow chatWindow)
        {
            InitializeComponent();

            // set the chat window form to the chatWindow variable
            this.chatWindow = chatWindow;
        }

        #region Button Funcs

        private void newAccountCheck_CheckedChanged(object sender, System.EventArgs e)
        {
            // if the register new account checkbox is check then enabled the add pfp btn
            if (newAccountCheck.Checked)
            {
                addPictureBtn.Enabled = true;
                loginBtn.Text = "Register";
            }
            else 
            {
                addPictureBtn.Enabled = false;
                loginBtn.Text = "Login";
            }
            
        }

        private void addPictureBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                // get the profile picture from the file controller class
                Image profilePic = FileController.GetProfilePicture(openFileDialog);

                // if the profile picture is not null then set the profile picture
                profilePicture.Image = profilePic;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
            
        }

        private async void loginBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                // check if the user wants to register a new account
                if (newAccountCheck.Checked)
                {
                    // if the profile picture is not null then register the user
                    if (profilePicture.Image != null)
                    {
                        // if the image path is not null and the image exists then continue
                        if (!string.IsNullOrWhiteSpace(openFileDialog.FileName) && File.Exists(openFileDialog.FileName))
                        {
                            // convert the image to a byte array and register the user
                            byte[] imageData = await FileController.ConvertToByteArrayASync(openFileDialog.FileName);
                            await DbController.Register(usernameBox.Text, passwordBox.Text, imageData);
                        }
                        else
                        {
                            throw new Exception("Profile picture file not found. Please select a valid profile picture.");
                        }
                    }
                    else 
                    {
                        throw new Exception("Please select a profile picture!");
                    }
                    
                }
                else
                {
                    // if the user wants to login then login the user
                    bool loginCheck = await DbController.Login(usernameBox.Text, passwordBox.Text);

                    // if the login was successful then show the chat window and close the login window
                    if (loginCheck) 
                    {
                        // get the profile picture of the user
                        Image pfp = await DbController.GetProfilePicture(usernameBox.Text); 

                        // show the chat window with supplied username and profile picture
                        chatWindow.SetUserInfo(true, usernameBox.Text, pfp, false);
                        chatWindow.Show();

                        // close the login window
                        this.Close();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
            
        }
        #endregion


        #region Events
        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // show the main chat window if user closes the form
            chatWindow.Show();
        }

        #endregion

    }
}
