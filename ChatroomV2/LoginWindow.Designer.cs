namespace ChatroomV2
{
    partial class LoginWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.loginBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.usernameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.profilePicture = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.passwordBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.newAccountCheck = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.addPictureBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.Orange;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(61, 276);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(302, 32);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Animated = true;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "";
            this.usernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.Location = new System.Drawing.Point(61, 115);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderText = "Username\r\n";
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(302, 32);
            this.usernameBox.TabIndex = 8;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.ImageRotate = 0F;
            this.profilePicture.Location = new System.Drawing.Point(61, 18);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.profilePicture.Size = new System.Drawing.Size(64, 64);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 7;
            this.profilePicture.TabStop = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Animated = true;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Location = new System.Drawing.Point(61, 177);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "Password";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(302, 32);
            this.passwordBox.TabIndex = 10;
            // 
            // newAccountCheck
            // 
            this.newAccountCheck.AutoSize = true;
            this.newAccountCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newAccountCheck.CheckedState.BorderRadius = 0;
            this.newAccountCheck.CheckedState.BorderThickness = 0;
            this.newAccountCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newAccountCheck.Location = new System.Drawing.Point(61, 231);
            this.newAccountCheck.Name = "newAccountCheck";
            this.newAccountCheck.Size = new System.Drawing.Size(139, 17);
            this.newAccountCheck.TabIndex = 11;
            this.newAccountCheck.Text = "Register New Account?";
            this.newAccountCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.newAccountCheck.UncheckedState.BorderRadius = 0;
            this.newAccountCheck.UncheckedState.BorderThickness = 0;
            this.newAccountCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.newAccountCheck.CheckedChanged += new System.EventHandler(this.newAccountCheck_CheckedChanged);
            // 
            // addPictureBtn
            // 
            this.addPictureBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addPictureBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addPictureBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addPictureBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addPictureBtn.Enabled = false;
            this.addPictureBtn.FillColor = System.Drawing.Color.Orange;
            this.addPictureBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addPictureBtn.ForeColor = System.Drawing.Color.White;
            this.addPictureBtn.Location = new System.Drawing.Point(141, 40);
            this.addPictureBtn.Name = "addPictureBtn";
            this.addPictureBtn.Size = new System.Drawing.Size(93, 19);
            this.addPictureBtn.TabIndex = 12;
            this.addPictureBtn.Text = "Add Picture";
            this.addPictureBtn.Click += new System.EventHandler(this.addPictureBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 341);
            this.Controls.Add(this.addPictureBtn);
            this.Controls.Add(this.newAccountCheck);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.profilePicture);
            this.Name = "LoginWindow";
            this.Text = "Chatroom | Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton loginBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox usernameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox profilePicture;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox passwordBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox newAccountCheck;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addPictureBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}