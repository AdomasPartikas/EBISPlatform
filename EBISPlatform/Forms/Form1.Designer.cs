namespace EBISPlatform
{
    partial class LoginForm
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
            this.loginTxtBox_username = new System.Windows.Forms.TextBox();
            this.loginTxtBox_password = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginLbl_username = new System.Windows.Forms.Label();
            this.loginLbl_password = new System.Windows.Forms.Label();
            this.loginLinkLbl = new System.Windows.Forms.LinkLabel();
            this.showPasswordChckBox = new System.Windows.Forms.CheckBox();
            this.errorMessageLbl = new System.Windows.Forms.Label();
            this.rememberMeChckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginTxtBox_username
            // 
            this.loginTxtBox_username.Location = new System.Drawing.Point(182, 102);
            this.loginTxtBox_username.Name = "loginTxtBox_username";
            this.loginTxtBox_username.Size = new System.Drawing.Size(294, 26);
            this.loginTxtBox_username.TabIndex = 0;
            // 
            // loginTxtBox_password
            // 
            this.loginTxtBox_password.Location = new System.Drawing.Point(182, 182);
            this.loginTxtBox_password.Name = "loginTxtBox_password";
            this.loginTxtBox_password.PasswordChar = '*';
            this.loginTxtBox_password.Size = new System.Drawing.Size(294, 26);
            this.loginTxtBox_password.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Location = new System.Drawing.Point(182, 265);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(294, 51);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginLbl_username
            // 
            this.loginLbl_username.AutoSize = true;
            this.loginLbl_username.Location = new System.Drawing.Point(182, 75);
            this.loginLbl_username.Name = "loginLbl_username";
            this.loginLbl_username.Size = new System.Drawing.Size(126, 20);
            this.loginLbl_username.TabIndex = 3;
            this.loginLbl_username.Text = "Username/Email";
            // 
            // loginLbl_password
            // 
            this.loginLbl_password.AutoSize = true;
            this.loginLbl_password.Location = new System.Drawing.Point(182, 158);
            this.loginLbl_password.Name = "loginLbl_password";
            this.loginLbl_password.Size = new System.Drawing.Size(78, 20);
            this.loginLbl_password.TabIndex = 4;
            this.loginLbl_password.Text = "Password";
            // 
            // loginLinkLbl
            // 
            this.loginLinkLbl.AutoSize = true;
            this.loginLinkLbl.Location = new System.Drawing.Point(184, 228);
            this.loginLinkLbl.Name = "loginLinkLbl";
            this.loginLinkLbl.Size = new System.Drawing.Size(177, 20);
            this.loginLinkLbl.TabIndex = 5;
            this.loginLinkLbl.TabStop = true;
            this.loginLinkLbl.Text = "Don\'t have an account?";
            this.loginLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLbl_LinkClicked);
            // 
            // showPasswordChckBox
            // 
            this.showPasswordChckBox.AutoSize = true;
            this.showPasswordChckBox.Location = new System.Drawing.Point(476, 214);
            this.showPasswordChckBox.Name = "showPasswordChckBox";
            this.showPasswordChckBox.Size = new System.Drawing.Size(148, 24);
            this.showPasswordChckBox.TabIndex = 13;
            this.showPasswordChckBox.Text = "Show Password";
            this.showPasswordChckBox.UseVisualStyleBackColor = true;
            this.showPasswordChckBox.CheckedChanged += new System.EventHandler(this.showPasswordChckBox_CheckedChanged);
            // 
            // errorMessageLbl
            // 
            this.errorMessageLbl.AutoSize = true;
            this.errorMessageLbl.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLbl.Location = new System.Drawing.Point(184, 367);
            this.errorMessageLbl.Name = "errorMessageLbl";
            this.errorMessageLbl.Size = new System.Drawing.Size(278, 20);
            this.errorMessageLbl.TabIndex = 14;
            this.errorMessageLbl.Text = "Incorrect password or username/email";
            this.errorMessageLbl.Visible = false;
            // 
            // rememberMeChckBox
            // 
            this.rememberMeChckBox.AutoSize = true;
            this.rememberMeChckBox.Location = new System.Drawing.Point(188, 323);
            this.rememberMeChckBox.Name = "rememberMeChckBox";
            this.rememberMeChckBox.Size = new System.Drawing.Size(140, 24);
            this.rememberMeChckBox.TabIndex = 15;
            this.rememberMeChckBox.Text = "Remember me";
            this.rememberMeChckBox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 409);
            this.Controls.Add(this.rememberMeChckBox);
            this.Controls.Add(this.errorMessageLbl);
            this.Controls.Add(this.showPasswordChckBox);
            this.Controls.Add(this.loginLinkLbl);
            this.Controls.Add(this.loginLbl_password);
            this.Controls.Add(this.loginLbl_username);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginTxtBox_password);
            this.Controls.Add(this.loginTxtBox_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Ebis";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxtBox_username;
        private System.Windows.Forms.TextBox loginTxtBox_password;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label loginLbl_username;
        private System.Windows.Forms.Label loginLbl_password;
        private System.Windows.Forms.LinkLabel loginLinkLbl;
        private System.Windows.Forms.CheckBox showPasswordChckBox;
        private System.Windows.Forms.Label errorMessageLbl;
        private System.Windows.Forms.CheckBox rememberMeChckBox;
    }
}

