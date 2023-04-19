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
            //LoginForm l = new LoginForm();
            //l.Show();
            //this.Close();
            LoginForm.ActiveForm.Show();
        }
    }
}
