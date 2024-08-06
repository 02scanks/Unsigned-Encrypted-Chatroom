namespace ChatroomV2
{
    partial class ChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this.userNameLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.profilePicture = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.signInBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userMessageBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.sendMessageBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.messageBox = new System.Windows.Forms.ListBox();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.changeKeyBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.changeIVBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.keyDisplayBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ivDisplayBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.overlayToggle = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.overlayKeyIV = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Location = new System.Drawing.Point(528, 23);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(69, 15);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Not logged in!";
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.ImageRotate = 0F;
            this.profilePicture.Location = new System.Drawing.Point(619, 12);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.profilePicture.Size = new System.Drawing.Size(64, 64);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // signInBtn
            // 
            this.signInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInBtn.FillColor = System.Drawing.Color.Orange;
            this.signInBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(528, 44);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(66, 20);
            this.signInBtn.TabIndex = 3;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // userMessageBox
            // 
            this.userMessageBox.Animated = true;
            this.userMessageBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userMessageBox.DefaultText = "";
            this.userMessageBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userMessageBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userMessageBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userMessageBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userMessageBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userMessageBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userMessageBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userMessageBox.Location = new System.Drawing.Point(224, 350);
            this.userMessageBox.Name = "userMessageBox";
            this.userMessageBox.PasswordChar = '\0';
            this.userMessageBox.PlaceholderText = "Type A Message";
            this.userMessageBox.SelectedText = "";
            this.userMessageBox.Size = new System.Drawing.Size(459, 50);
            this.userMessageBox.TabIndex = 5;
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendMessageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendMessageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendMessageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendMessageBtn.FillColor = System.Drawing.Color.Orange;
            this.sendMessageBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendMessageBtn.ForeColor = System.Drawing.Color.White;
            this.sendMessageBtn.Location = new System.Drawing.Point(224, 406);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(459, 32);
            this.sendMessageBtn.TabIndex = 6;
            this.sendMessageBtn.Text = "Send";
            this.sendMessageBtn.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // messageBox
            // 
            this.messageBox.FormattingEnabled = true;
            this.messageBox.Location = new System.Drawing.Point(224, 96);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(459, 251);
            this.messageBox.TabIndex = 7;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(245, -2);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(206, 94);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 8;
            this.siticonePictureBox1.TabStop = false;
            // 
            // changeKeyBtn
            // 
            this.changeKeyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeKeyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeKeyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeKeyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeKeyBtn.FillColor = System.Drawing.Color.Orange;
            this.changeKeyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeKeyBtn.ForeColor = System.Drawing.Color.White;
            this.changeKeyBtn.Location = new System.Drawing.Point(12, 190);
            this.changeKeyBtn.Name = "changeKeyBtn";
            this.changeKeyBtn.Size = new System.Drawing.Size(92, 20);
            this.changeKeyBtn.TabIndex = 9;
            this.changeKeyBtn.Text = "Change Key";
            this.changeKeyBtn.Click += new System.EventHandler(this.changeKeyBtn_Click);
            // 
            // changeIVBtn
            // 
            this.changeIVBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeIVBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeIVBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeIVBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeIVBtn.FillColor = System.Drawing.Color.Orange;
            this.changeIVBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeIVBtn.ForeColor = System.Drawing.Color.White;
            this.changeIVBtn.Location = new System.Drawing.Point(12, 244);
            this.changeIVBtn.Name = "changeIVBtn";
            this.changeIVBtn.Size = new System.Drawing.Size(92, 20);
            this.changeIVBtn.TabIndex = 10;
            this.changeIVBtn.Text = "Change IV";
            this.changeIVBtn.Click += new System.EventHandler(this.changeIVBtn_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.AutoSize = false;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(206, 145);
            this.siticoneHtmlLabel1.TabIndex = 11;
            this.siticoneHtmlLabel1.Text = resources.GetString("siticoneHtmlLabel1.Text");
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyDisplayBox
            // 
            this.keyDisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyDisplayBox.DefaultText = "LYVjOI8HSHgn8BAs3mML4gohbfwea5Fl";
            this.keyDisplayBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keyDisplayBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keyDisplayBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyDisplayBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyDisplayBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyDisplayBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyDisplayBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyDisplayBox.Location = new System.Drawing.Point(12, 216);
            this.keyDisplayBox.Name = "keyDisplayBox";
            this.keyDisplayBox.PasswordChar = '\0';
            this.keyDisplayBox.PlaceholderText = "";
            this.keyDisplayBox.ReadOnly = true;
            this.keyDisplayBox.SelectedText = "";
            this.keyDisplayBox.Size = new System.Drawing.Size(190, 22);
            this.keyDisplayBox.TabIndex = 12;
            // 
            // ivDisplayBox
            // 
            this.ivDisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ivDisplayBox.DefaultText = "5Flbfwea4gohLYVj";
            this.ivDisplayBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ivDisplayBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ivDisplayBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ivDisplayBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ivDisplayBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ivDisplayBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ivDisplayBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ivDisplayBox.Location = new System.Drawing.Point(12, 270);
            this.ivDisplayBox.Name = "ivDisplayBox";
            this.ivDisplayBox.PasswordChar = '\0';
            this.ivDisplayBox.PlaceholderText = "";
            this.ivDisplayBox.ReadOnly = true;
            this.ivDisplayBox.SelectedText = "";
            this.ivDisplayBox.Size = new System.Drawing.Size(190, 22);
            this.ivDisplayBox.TabIndex = 13;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.AutoSize = false;
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(24, 298);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(168, 31);
            this.siticoneHtmlLabel2.TabIndex = 14;
            this.siticoneHtmlLabel2.Text = "IV must be 16 unique characters\r\n\r\nKey must be 32 unique characters\r\n";
            this.siticoneHtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // overlayToggle
            // 
            this.overlayToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.overlayToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.overlayToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.overlayToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.overlayToggle.Location = new System.Drawing.Point(12, 418);
            this.overlayToggle.Name = "overlayToggle";
            this.overlayToggle.Size = new System.Drawing.Size(35, 20);
            this.overlayToggle.TabIndex = 15;
            this.overlayToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.overlayToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.overlayToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.overlayToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.overlayToggle.CheckedChanged += new System.EventHandler(this.overlayToggle_CheckedChanged);
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.AutoSize = false;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(47, 412);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(98, 31);
            this.siticoneHtmlLabel3.TabIndex = 16;
            this.siticoneHtmlLabel3.Text = "Toggle Hide/Show Key and IV";
            this.siticoneHtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // overlayKeyIV
            // 
            this.overlayKeyIV.Location = new System.Drawing.Point(12, 181);
            this.overlayKeyIV.Name = "overlayKeyIV";
            this.overlayKeyIV.Size = new System.Drawing.Size(200, 166);
            this.overlayKeyIV.TabIndex = 17;
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.overlayKeyIV);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.overlayToggle);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.ivDisplayBox);
            this.Controls.Add(this.keyDisplayBox);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.changeIVBtn);
            this.Controls.Add(this.changeKeyBtn);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.sendMessageBtn);
            this.Controls.Add(this.userMessageBox);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.userNameLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChatWindow";
            this.Text = "Unsigned";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel userNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox profilePicture;
        private Siticone.Desktop.UI.WinForms.SiticoneButton signInBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userMessageBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sendMessageBtn;
        private System.Windows.Forms.ListBox messageBox;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton changeKeyBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton changeIVBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox keyDisplayBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ivDisplayBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch overlayToggle;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private System.Windows.Forms.Panel overlayKeyIV;
    }
}

