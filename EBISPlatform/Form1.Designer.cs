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
            this.SuspendLayout();
            // 
            // loginTxtBox_username
            // 
            this.loginTxtBox_username.Location = new System.Drawing.Point(121, 66);
            this.loginTxtBox_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginTxtBox_username.Name = "loginTxtBox_username";
            this.loginTxtBox_username.Size = new System.Drawing.Size(197, 20);
            this.loginTxtBox_username.TabIndex = 0;
            // 
            // loginTxtBox_password
            // 
            this.loginTxtBox_password.Location = new System.Drawing.Point(121, 118);
            this.loginTxtBox_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginTxtBox_password.Name = "loginTxtBox_password";
            this.loginTxtBox_password.PasswordChar = '*';
            this.loginTxtBox_password.Size = new System.Drawing.Size(197, 20);
            this.loginTxtBox_password.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Location = new System.Drawing.Point(121, 172);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(196, 33);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginLbl_username
            // 
            this.loginLbl_username.AutoSize = true;
            this.loginLbl_username.Location = new System.Drawing.Point(121, 49);
            this.loginLbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLbl_username.Name = "loginLbl_username";
            this.loginLbl_username.Size = new System.Drawing.Size(53, 13);
            this.loginLbl_username.TabIndex = 3;
            this.loginLbl_username.Text = "username";
            // 
            // loginLbl_password
            // 
            this.loginLbl_password.AutoSize = true;
            this.loginLbl_password.Location = new System.Drawing.Point(121, 103);
            this.loginLbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLbl_password.Name = "loginLbl_password";
            this.loginLbl_password.Size = new System.Drawing.Size(52, 13);
            this.loginLbl_password.TabIndex = 4;
            this.loginLbl_password.Text = "password";
            // 
            // loginLinkLbl
            // 
            this.loginLinkLbl.AutoSize = true;
            this.loginLinkLbl.Location = new System.Drawing.Point(123, 148);
            this.loginLinkLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLinkLbl.Name = "loginLinkLbl";
            this.loginLinkLbl.Size = new System.Drawing.Size(122, 13);
            this.loginLinkLbl.TabIndex = 5;
            this.loginLinkLbl.TabStop = true;
            this.loginLinkLbl.Text = "Don\'t have an account?";
            this.loginLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLbl_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 224);
            this.Controls.Add(this.loginLinkLbl);
            this.Controls.Add(this.loginLbl_password);
            this.Controls.Add(this.loginLbl_username);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginTxtBox_password);
            this.Controls.Add(this.loginTxtBox_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Ebis";
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
    }
}

