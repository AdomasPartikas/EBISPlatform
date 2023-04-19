namespace EBISPlatform.Functions
{
    partial class SignUpForm
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
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordRepeatLbl = new System.Windows.Forms.Label();
            this.passwordRepeatTxtBox = new System.Windows.Forms.TextBox();
            this.showPasswordChckBox = new System.Windows.Forms.CheckBox();
            this.passwordMatchLbl = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.nameMsgLbl = new System.Windows.Forms.Label();
            this.usernameMsgLbl = new System.Windows.Forms.Label();
            this.emailMsgLbl = new System.Windows.Forms.Label();
            this.passwordMsgLbl = new System.Windows.Forms.Label();
            this.sqlResponseLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(103, 83);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(255, 26);
            this.firstNameTxtBox.TabIndex = 0;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(103, 57);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(51, 20);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(103, 115);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(86, 20);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "Last Name";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(103, 141);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(255, 26);
            this.lastNameTxtBox.TabIndex = 2;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(103, 178);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(83, 20);
            this.userNameLbl.TabIndex = 5;
            this.userNameLbl.Text = "Username";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(103, 204);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(255, 26);
            this.userNameTxtBox.TabIndex = 4;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(103, 240);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(48, 20);
            this.emailLbl.TabIndex = 7;
            this.emailLbl.Text = "Email";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(103, 266);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(255, 26);
            this.emailTxtBox.TabIndex = 6;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(103, 338);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(78, 20);
            this.passwordLbl.TabIndex = 9;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(103, 364);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(255, 26);
            this.passwordTxtBox.TabIndex = 8;
            this.passwordTxtBox.TextChanged += new System.EventHandler(this.passwordRepeatTxtBox_TextChanged);
            // 
            // passwordRepeatLbl
            // 
            this.passwordRepeatLbl.AutoSize = true;
            this.passwordRepeatLbl.Location = new System.Drawing.Point(103, 395);
            this.passwordRepeatLbl.Name = "passwordRepeatLbl";
            this.passwordRepeatLbl.Size = new System.Drawing.Size(134, 20);
            this.passwordRepeatLbl.TabIndex = 11;
            this.passwordRepeatLbl.Text = "Repeat password";
            // 
            // passwordRepeatTxtBox
            // 
            this.passwordRepeatTxtBox.Location = new System.Drawing.Point(103, 421);
            this.passwordRepeatTxtBox.Name = "passwordRepeatTxtBox";
            this.passwordRepeatTxtBox.PasswordChar = '*';
            this.passwordRepeatTxtBox.Size = new System.Drawing.Size(255, 26);
            this.passwordRepeatTxtBox.TabIndex = 10;
            this.passwordRepeatTxtBox.TextChanged += new System.EventHandler(this.passwordRepeatTxtBox_TextChanged);
            // 
            // showPasswordChckBox
            // 
            this.showPasswordChckBox.AutoSize = true;
            this.showPasswordChckBox.Location = new System.Drawing.Point(365, 395);
            this.showPasswordChckBox.Name = "showPasswordChckBox";
            this.showPasswordChckBox.Size = new System.Drawing.Size(148, 24);
            this.showPasswordChckBox.TabIndex = 12;
            this.showPasswordChckBox.Text = "Show Password";
            this.showPasswordChckBox.UseVisualStyleBackColor = true;
            this.showPasswordChckBox.CheckedChanged += new System.EventHandler(this.showPasswordChckBox_CheckedChanged);
            // 
            // passwordMatchLbl
            // 
            this.passwordMatchLbl.AutoSize = true;
            this.passwordMatchLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordMatchLbl.Location = new System.Drawing.Point(107, 454);
            this.passwordMatchLbl.Name = "passwordMatchLbl";
            this.passwordMatchLbl.Size = new System.Drawing.Size(193, 20);
            this.passwordMatchLbl.TabIndex = 13;
            this.passwordMatchLbl.Text = "*Passwords do not match!";
            this.passwordMatchLbl.Visible = false;
            // 
            // signUpBtn
            // 
            this.signUpBtn.FlatAppearance.BorderSize = 0;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpBtn.Location = new System.Drawing.Point(111, 502);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(247, 51);
            this.signUpBtn.TabIndex = 15;
            this.signUpBtn.Text = "Register";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // nameMsgLbl
            // 
            this.nameMsgLbl.AutoSize = true;
            this.nameMsgLbl.ForeColor = System.Drawing.Color.Red;
            this.nameMsgLbl.Location = new System.Drawing.Point(246, 172);
            this.nameMsgLbl.Name = "nameMsgLbl";
            this.nameMsgLbl.Size = new System.Drawing.Size(112, 20);
            this.nameMsgLbl.TabIndex = 16;
            this.nameMsgLbl.Text = "*Needed fields";
            this.nameMsgLbl.Visible = false;
            // 
            // usernameMsgLbl
            // 
            this.usernameMsgLbl.AutoSize = true;
            this.usernameMsgLbl.ForeColor = System.Drawing.Color.Red;
            this.usernameMsgLbl.Location = new System.Drawing.Point(229, 235);
            this.usernameMsgLbl.Name = "usernameMsgLbl";
            this.usernameMsgLbl.Size = new System.Drawing.Size(129, 20);
            this.usernameMsgLbl.TabIndex = 17;
            this.usernameMsgLbl.Text = "*Enter username";
            this.usernameMsgLbl.Visible = false;
            // 
            // emailMsgLbl
            // 
            this.emailMsgLbl.AutoSize = true;
            this.emailMsgLbl.ForeColor = System.Drawing.Color.Red;
            this.emailMsgLbl.Location = new System.Drawing.Point(263, 300);
            this.emailMsgLbl.Name = "emailMsgLbl";
            this.emailMsgLbl.Size = new System.Drawing.Size(95, 20);
            this.emailMsgLbl.TabIndex = 18;
            this.emailMsgLbl.Text = "*Enter email";
            this.emailMsgLbl.Visible = false;
            // 
            // passwordMsgLbl
            // 
            this.passwordMsgLbl.AutoSize = true;
            this.passwordMsgLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordMsgLbl.Location = new System.Drawing.Point(107, 474);
            this.passwordMsgLbl.Name = "passwordMsgLbl";
            this.passwordMsgLbl.Size = new System.Drawing.Size(126, 20);
            this.passwordMsgLbl.TabIndex = 19;
            this.passwordMsgLbl.Text = "*Enter password";
            this.passwordMsgLbl.Visible = false;
            // 
            // sqlResponseLbl
            // 
            this.sqlResponseLbl.AutoSize = true;
            this.sqlResponseLbl.ForeColor = System.Drawing.Color.Red;
            this.sqlResponseLbl.Location = new System.Drawing.Point(66, 556);
            this.sqlResponseLbl.Name = "sqlResponseLbl";
            this.sqlResponseLbl.Size = new System.Drawing.Size(343, 20);
            this.sqlResponseLbl.TabIndex = 20;
            this.sqlResponseLbl.Text = "Email jababa@gmail.com is already being used!";
            this.sqlResponseLbl.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 630);
            this.Controls.Add(this.sqlResponseLbl);
            this.Controls.Add(this.passwordMsgLbl);
            this.Controls.Add(this.emailMsgLbl);
            this.Controls.Add(this.usernameMsgLbl);
            this.Controls.Add(this.nameMsgLbl);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.passwordMatchLbl);
            this.Controls.Add(this.showPasswordChckBox);
            this.Controls.Add(this.passwordRepeatLbl);
            this.Controls.Add(this.passwordRepeatTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.firstNameTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUpForm";
            this.Text = "Ebis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordRepeatLbl;
        private System.Windows.Forms.TextBox passwordRepeatTxtBox;
        private System.Windows.Forms.CheckBox showPasswordChckBox;
        private System.Windows.Forms.Label passwordMatchLbl;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label nameMsgLbl;
        private System.Windows.Forms.Label usernameMsgLbl;
        private System.Windows.Forms.Label emailMsgLbl;
        private System.Windows.Forms.Label passwordMsgLbl;
        private System.Windows.Forms.Label sqlResponseLbl;
    }
}