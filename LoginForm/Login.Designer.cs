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
            txtDui = new TextBox();
            txtContraseña = new TextBox();
            contraseñaCuenta = new Label();
            btnSesion = new Button();
            SuspendLayout();
            // 
            // inicioCuenta
            // 
            inicioCuenta.AutoSize = true;
            inicioCuenta.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inicioCuenta.Location = new Point(254, 94);
            inicioCuenta.Name = "inicioCuenta";
            inicioCuenta.Size = new Size(270, 29);
            inicioCuenta.TabIndex = 0;
            inicioCuenta.Text = "Inicie sesión en su cuenta";
            // 
            // duiCuenta
            // 
            duiCuenta.AutoSize = true;
            duiCuenta.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duiCuenta.Location = new Point(254, 200);
            duiCuenta.Name = "duiCuenta";
            duiCuenta.Size = new Size(46, 23);
            duiCuenta.TabIndex = 1;
            duiCuenta.Text = "DUI:";
            // 
            // txtDui
            // 
            txtDui.Location = new Point(381, 192);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(219, 23);
            txtDui.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(381, 267);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(219, 23);
            txtContraseña.TabIndex = 4;
            // 
            // contraseñaCuenta
            // 
            contraseñaCuenta.AutoSize = true;
            contraseñaCuenta.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaCuenta.Location = new Point(223, 267);
            contraseñaCuenta.Name = "contraseñaCuenta";
            contraseñaCuenta.Size = new Size(104, 23);
            contraseñaCuenta.TabIndex = 3;
            contraseñaCuenta.Text = "Contraseña:";
            // 
            // btnSesion
            // 
            btnSesion.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSesion.Location = new Point(354, 333);
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
            Controls.Add(txtContraseña);
            Controls.Add(contraseñaCuenta);
            Controls.Add(txtDui);
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
        private TextBox txtDui;
        private TextBox txtContraseña;
        private Label contraseñaCuenta;
        private Button btnSesion;
    }
}
