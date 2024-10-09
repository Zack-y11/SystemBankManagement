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
            inicioCuenta = new Label();
            duiCuenta = new Label();
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            contraseñaCuenta = new Label();
            btnSesion = new Button();
            SuspendLayout();
            // 
            // inicioCuenta
            // 
            inicioCuenta.AutoSize = true;
            inicioCuenta.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inicioCuenta.Location = new Point(254, 24);
            inicioCuenta.Name = "inicioCuenta";
            inicioCuenta.Size = new Size(270, 29);
            inicioCuenta.TabIndex = 0;
            inicioCuenta.Text = "Inicie sesión en su cuenta";
            // 
            // duiCuenta
            // 
            duiCuenta.AutoSize = true;
            duiCuenta.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duiCuenta.Location = new Point(254, 93);
            duiCuenta.Name = "duiCuenta";
            duiCuenta.Size = new Size(46, 23);
            duiCuenta.TabIndex = 1;
            duiCuenta.Text = "DUI:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(354, 93);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(219, 23);
            nameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(354, 149);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(219, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // contraseñaCuenta
            // 
            contraseñaCuenta.AutoSize = true;
            contraseñaCuenta.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaCuenta.Location = new Point(196, 149);
            contraseñaCuenta.Name = "contraseñaCuenta";
            contraseñaCuenta.Size = new Size(104, 23);
            contraseñaCuenta.TabIndex = 3;
            contraseñaCuenta.Text = "Contraseña:";
            // 
            // btnSesion
            // 
            btnSesion.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSesion.Location = new Point(354, 223);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(90, 38);
            btnSesion.TabIndex = 5;
            btnSesion.Text = "Iniciar";
            btnSesion.UseVisualStyleBackColor = true;
            btnSesion.Click += btnSesion_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSesion);
            Controls.Add(passwordTextBox);
            Controls.Add(contraseñaCuenta);
            Controls.Add(nameTextBox);
            Controls.Add(duiCuenta);
            Controls.Add(inicioCuenta);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inicioCuenta;
        private Label duiCuenta;
        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private Label contraseñaCuenta;
        private Button btnSesion;
    }
}
