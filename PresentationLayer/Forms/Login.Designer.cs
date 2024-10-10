namespace LoginForm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            homeAccount = new Label();
            duiLogin = new Label();
            duiTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLogin = new Label();
            btnSession = new Button();
            errorLogin = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorLogin).BeginInit();
            SuspendLayout();
            // 
            // homeAccount
            // 
            homeAccount.AutoSize = true;
            homeAccount.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeAccount.Location = new Point(254, 24);
            homeAccount.Name = "homeAccount";
            homeAccount.Size = new Size(270, 29);
            homeAccount.TabIndex = 0;
            homeAccount.Text = "Inicie sesión en su cuenta";
            // 
            // duiLogin
            // 
            duiLogin.AutoSize = true;
            duiLogin.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duiLogin.Location = new Point(254, 93);
            duiLogin.Name = "duiLogin";
            duiLogin.Size = new Size(46, 23);
            duiLogin.TabIndex = 1;
            duiLogin.Text = "DUI:";
            // 
            // duiTextBox
            // 
            duiTextBox.Location = new Point(354, 93);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(219, 23);
            duiTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(354, 149);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(219, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLogin
            // 
            passwordLogin.AutoSize = true;
            passwordLogin.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLogin.Location = new Point(196, 149);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(104, 23);
            passwordLogin.TabIndex = 3;
            passwordLogin.Text = "Contraseña:";
            // 
            // btnSession
            // 
            btnSession.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSession.Location = new Point(354, 223);
            btnSession.Name = "btnSession";
            btnSession.Size = new Size(90, 38);
            btnSession.TabIndex = 5;
            btnSession.Text = "Iniciar";
            btnSession.UseVisualStyleBackColor = true;
            btnSession.Click += btnSesion_Click;
            // 
            // errorLogin
            // 
            errorLogin.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSession);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLogin);
            Controls.Add(duiTextBox);
            Controls.Add(duiLogin);
            Controls.Add(homeAccount);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label homeAccount;
        private Label duiLogin;
        private TextBox duiTextBox;
        private TextBox passwordTextBox;
        private Label passwordLogin;
        private Button btnSession;
        private ErrorProvider errorLogin;
    }
}
