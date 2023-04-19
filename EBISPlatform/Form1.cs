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
    }
}
