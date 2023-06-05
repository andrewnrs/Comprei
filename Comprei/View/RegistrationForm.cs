using Comprei.Controller;

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


        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
            _loginForm.Focus();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _customerController.RegisterCustomer(nameTxtBx.Text, loginTxtBx.Text, passwordTxtBx.Text, houseTxtBx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao cadastrar cliente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Close();
        }
    }
}
