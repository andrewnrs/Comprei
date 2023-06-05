namespace Comprei.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameTxtBx = new TextBox();
            passwordTxtBx = new TextBox();
            loginBtn = new Button();
            RegistrationMenuSt = new MenuStrip();
            registrationMenuItem = new ToolStripMenuItem();
            RegistrationMenuSt.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTxtBx
            // 
            resources.ApplyResources(usernameTxtBx, "usernameTxtBx");
            usernameTxtBx.Name = "usernameTxtBx";
            // 
            // passwordTxtBx
            // 
            resources.ApplyResources(passwordTxtBx, "passwordTxtBx");
            passwordTxtBx.Name = "passwordTxtBx";
            // 
            // loginBtn
            // 
            resources.ApplyResources(loginBtn, "loginBtn");
            loginBtn.Name = "loginBtn";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // RegistrationMenuSt
            // 
            resources.ApplyResources(RegistrationMenuSt, "RegistrationMenuSt");
            RegistrationMenuSt.Items.AddRange(new ToolStripItem[] { registrationMenuItem });
            RegistrationMenuSt.Name = "RegistrationMenuSt";
            // 
            // registrationMenuItem
            // 
            resources.ApplyResources(registrationMenuItem, "registrationMenuItem");
            registrationMenuItem.Name = "registrationMenuItem";
            registrationMenuItem.Click += registrationToolStripMenuItem_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(loginBtn);
            Controls.Add(passwordTxtBx);
            Controls.Add(usernameTxtBx);
            Controls.Add(RegistrationMenuSt);
            HelpButton = true;
            MainMenuStrip = RegistrationMenuSt;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RegistrationMenuSt.ResumeLayout(false);
            RegistrationMenuSt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxtBx;
        private TextBox passwordTxtBx;
        private Button loginBtn;
        private MenuStrip RegistrationMenuSt;
        private ToolStripMenuItem registrationMenuItem;
    }
}