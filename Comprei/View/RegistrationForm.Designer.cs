namespace Comprei.View
{
    partial class RegistrationForm
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
            loginTxtBx = new TextBox();
            passwordTxtBx = new TextBox();
            nameTxtBx = new TextBox();
            houseTxtBx = new TextBox();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // loginTxtBx
            // 
            loginTxtBx.Location = new Point(50, 50);
            loginTxtBx.Name = "loginTxtBx";
            loginTxtBx.PlaceholderText = "Login";
            loginTxtBx.Size = new Size(200, 23);
            loginTxtBx.TabIndex = 0;
            // 
            // passwordTxtBx
            // 
            passwordTxtBx.Location = new Point(50, 93);
            passwordTxtBx.Name = "passwordTxtBx";
            passwordTxtBx.PlaceholderText = "Senha forte";
            passwordTxtBx.Size = new Size(200, 23);
            passwordTxtBx.TabIndex = 1;
            // 
            // nameTxtBx
            // 
            nameTxtBx.Location = new Point(50, 136);
            nameTxtBx.Name = "nameTxtBx";
            nameTxtBx.PlaceholderText = "Nome Completo";
            nameTxtBx.Size = new Size(200, 23);
            nameTxtBx.TabIndex = 2;
            // 
            // houseTxtBx
            // 
            houseTxtBx.Location = new Point(50, 185);
            houseTxtBx.Name = "houseTxtBx";
            houseTxtBx.PlaceholderText = "Apelido para sua Casa";
            houseTxtBx.Size = new Size(200, 23);
            houseTxtBx.TabIndex = 3;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(102, 267);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "Cadastrar!";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(registerBtn);
            Controls.Add(houseTxtBx);
            Controls.Add(nameTxtBx);
            Controls.Add(passwordTxtBx);
            Controls.Add(loginTxtBx);
            HelpButton = true;
            MaximizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastre-se aqui";
            FormClosing += EnrollmentForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTxtBx;
        private TextBox passwordTxtBx;
        private TextBox nameTxtBx;
        private TextBox houseTxtBx;
        private Button registerBtn;
    }
}