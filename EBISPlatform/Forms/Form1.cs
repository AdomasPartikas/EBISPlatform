using EBISPlatform.Forms;
using EBISPlatform.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBISPlatform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = loginTxtBox_username.Text;
            var password = loginTxtBox_password.Text;

            SQL sql = new SQL();
            
            if(sql.IsLoginValid(username,password))
            {
                if(rememberMeChckBox.Checked == true)
                {
                    ConfigJson configJson = new ConfigJson();
                    configJson.EditJsonAsync(username,password).GetAwaiter();
                }

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                errorMessageLbl.Visible = true;
            }
        }

        private void loginLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms["SignUpForm"] == null)
            {
                SignUpForm s = new SignUpForm();
                s.Show();
            }
            else
            {
                var s = Application.OpenForms["SignUpForm"];
                s.Show();
            }
            this.Enabled = false;
        }

        private void showPasswordChckBox_CheckedChanged(object sender, EventArgs e)
        {
            var chckBox = (CheckBox)sender;
            if (chckBox.Checked)
                loginTxtBox_password.PasswordChar = '\0';
            else
                loginTxtBox_password.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (ConfigJson.jsonConfig.Username != "" && ConfigJson.jsonConfig.Password != "")
            {
                loginTxtBox_password.Text = ConfigJson.jsonConfig.Password;
                loginTxtBox_username.Text = ConfigJson.jsonConfig.Username;
            }
        }
    }
}
