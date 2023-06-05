using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprei.View
{
    public partial class HomePageForm : Form
    {
        LoginForm _loginForm;

        public HomePageForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void HomePageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
            _loginForm.Focus();
        }
    }
}
