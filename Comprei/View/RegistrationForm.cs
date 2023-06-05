using Comprei.Controller;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Comprei.View
{
    public partial class RegistrationForm : Form
    {
        LoginForm _loginForm;
        CustomerController _customerController;

        public RegistrationForm(LoginForm loginForm, CustomerController customerController)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _customerController = customerController;
        }


        private void EnrollmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
            _loginForm.Focus();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            _customerController.RegisterCustomer(nameTxtBx.Text, loginTxtBx.Text, passwordTxtBx.Text, houseTxtBx.Text);
            Close();
        }
    }
}
