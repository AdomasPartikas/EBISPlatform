using EBISPlatform.Local;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBISPlatform.Functions
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var l = Application.OpenForms["LoginForm"];
            l.Enabled = true;
        }

        private void showPasswordChckBox_CheckedChanged(object sender, EventArgs e)
        {
            var chckBox = (CheckBox)sender;
            if(chckBox.Checked)
            {
                passwordTxtBox.PasswordChar = '\0';
                passwordRepeatTxtBox.PasswordChar = '\0';
            }
            else
            {
                passwordTxtBox.PasswordChar = '*';
                passwordRepeatTxtBox.PasswordChar = '*';
            }
        }

        private void passwordRepeatTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordRepeatTxtBox.Text.Length > 0 && passwordTxtBox.Text.Length > 0)
            {
                if (passwordRepeatTxtBox.Text != passwordTxtBox.Text)
                    passwordMatchLbl.Visible = true;
                else
                    passwordMatchLbl.Visible = false;
            }
            else
                passwordMatchLbl.Visible = false;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            bool trySignUp = true;

            if (!string.IsNullOrWhiteSpace(firstNameTxtBox.Text) && !string.IsNullOrWhiteSpace(lastNameTxtBox.Text))
            {
                user.Name = firstNameTxtBox.Text;
                user.LastName = lastNameTxtBox.Text;
            }
            else
            {
                trySignUp = false;
                nameMsgLbl.Visible = true;
            }
            if(!string.IsNullOrWhiteSpace(emailTxtBox.Text))
                user.Email = emailTxtBox.Text;
            else
            {
                trySignUp = false;
                emailMsgLbl.Visible = true;
            }
            if (!string.IsNullOrWhiteSpace(passwordTxtBox.Text) && !passwordMatchLbl.Visible)
                user.Password = passwordTxtBox.Text;
            else
            {
                trySignUp = false;
                passwordMsgLbl.Visible = true;
            }
            if (!string.IsNullOrWhiteSpace(userNameTxtBox.Text))
                user.UserName = userNameTxtBox.Text;
            else
            {
                trySignUp = false;
                usernameMsgLbl.Visible = true;
            }

            if (!trySignUp)
                return;
            else
            {
                SQL sql = new SQL();
                var response = sql.SendAccountSQL(user);
                if (!string.IsNullOrEmpty(response))
                {
                    sqlResponseLbl.Text = response;
                    sqlResponseLbl.Visible = true;
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
