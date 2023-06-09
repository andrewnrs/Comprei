﻿using Comprei.Controller;

namespace Comprei.View
{
    public partial class LoginForm : Form
    {
        private readonly CustomerController _customerController;

        public LoginForm(CustomerController customerController)
        {
            _customerController = customerController;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTxtBx.Text;
            var userpass = passwordTxtBx.Text;

            try
            {

                var logged = _customerController.ValidateLogin(username, userpass);

                if (!logged)
                {
                    MessageBox.Show("Usuário e/ou senha estão incorretos", "Login inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            new HomePageForm(this).ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistrationForm(this, _customerController).ShowDialog();
        }

    }
}
