using ChatroomV2.Controllers;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Text;

namespace ChatroomV2
{
    public partial class ChatWindow : Form
    {
        public static byte[] key = null;
        public static byte[] iv = null;

        // initialize new chatController Object
        ChatController chatController = new ChatController();

        bool isLoggedIn = false;
        string userName = null;
        Image profilePic = null;

        //overlay settings
        bool showOverlay = true;

        //key and iv editing options
        bool keyEditing = false;
        bool ivEditing = false;

        public ChatWindow()
        {
            InitializeComponent();

            SetKeyAndIV();
        }

        #region Button Funcs
        private async void SendMessage_Click(object sender, System.EventArgs e)
        {
            // Check if the user is logged in
            if (!isLoggedIn)
            {
                MessageBox.Show("You must login before you can do that!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Try send a message
            await chatController.SendMessageAsync(userName, userMessageBox.Text);

            // Clear the message box
            userMessageBox.Text = string.Empty;
        }
        private void signInBtn_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(this);
            loginWindow.Show();

            this.Hide();
        }

        private void changeKeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //toggle key editing
                if (!keyEditing)
                {
                    keyEditing = true;
                    keyDisplayBox.ReadOnly = false;
                }
                else if (keyEditing)
                {
                    keyEditing = false;
                    keyDisplayBox.ReadOnly = true;

                    //set the key and iv once they are done editing
                    SetKeyAndIV();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void changeIVBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //toggle iv editing
                if (!ivEditing)
                {
                    ivEditing = true;
                    ivDisplayBox.ReadOnly = false;
                }
                else if (ivEditing)
                {
                    ivEditing = false;
                    ivDisplayBox.ReadOnly = true;

                    //set the key and iv once they are done editing
                    SetKeyAndIV();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void overlayToggle_CheckedChanged(object sender, EventArgs e)
        {
            //toggle overlay
            if (showOverlay)
            {
                showOverlay = false;
                overlayKeyIV.Hide();
            }
            else if (!showOverlay)
            {
                showOverlay = true;
                overlayKeyIV.Show();
            }
        }

        #endregion

        #region Custom Funcs

        public void SetUserInfo(bool loggedInStatus, string user, Image pfp, bool loginBtnStatus) 
        {
            // Set the user info
            isLoggedIn = loggedInStatus;
            userName = user;
            userNameLabel.Text = user;
            profilePicture.Image = pfp;

            // Enable / Disable the sign in button
            signInBtn.Enabled = loginBtnStatus;
        }

        private void SetKeyAndIV() 
        {
            // The key and IV used for encryption and decryption
            key = Encoding.UTF8.GetBytes(keyDisplayBox.Text);     //32 bytes
            iv = Encoding.UTF8.GetBytes(ivDisplayBox.Text);       //16 bytes
        }

        #endregion


        #region Events
        private async void Form1_Load(object sender, EventArgs e)
        {
            // load the chat controller and start the chat system
            chatController.InitAsync();
            await chatController.OnLoadAsync(messageBox);
        }
        #endregion

       
        

        
    }
}
