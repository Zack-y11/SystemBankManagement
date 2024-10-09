namespace PresentationLayer.Forms
{
    partial class AccountForm
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
            cuentasDataGridView = new DataGridView();
            saldoAccount = new Label();
            numAccount = new Label();
            this.txtSaldo = new TextBox();
            this.txtNumeroCuenta = new TextBox();
            fechaCuenta = new Label();
            txtFechaCuenta = new DateTimePicker();
            btnBorrarCuenta = new Button();
            btnEditarCuenta = new Button();
            ((System.ComponentModel.ISupportInitialize)cuentasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cuentasDataGridView
            // 
            cuentasDataGridView.BackgroundColor = Color.Khaki;
            cuentasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuentasDataGridView.Location = new Point(12, 196);
            cuentasDataGridView.Name = "cuentasDataGridView";
            cuentasDataGridView.Size = new Size(776, 197);
            cuentasDataGridView.TabIndex = 0;
            // 
            // saldoAccount
            // 
            saldoAccount.AutoSize = true;
            saldoAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saldoAccount.Location = new Point(261, 65);
            saldoAccount.Name = "saldoAccount";
            saldoAccount.Size = new Size(54, 19);
            saldoAccount.TabIndex = 11;
            saldoAccount.Text = "Saldo:";
            // 
            // numAccount
            // 
            numAccount.AutoSize = true;
            numAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAccount.Location = new Point(218, 31);
            numAccount.Name = "numAccount";
            numAccount.Size = new Size(145, 19);
            numAccount.TabIndex = 10;
            numAccount.Text = "Número de cuenta:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new Point(373, 66);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new Size(219, 23);
            this.txtSaldo.TabIndex = 9;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new Point(373, 27);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new Size(219, 23);
            this.txtNumeroCuenta.TabIndex = 8;
            // 
            // fechaCuenta
            // 
            fechaCuenta.AutoSize = true;
            fechaCuenta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaCuenta.Location = new Point(218, 114);
            fechaCuenta.Name = "fechaCuenta";
            fechaCuenta.Size = new Size(145, 19);
            fechaCuenta.TabIndex = 13;
            fechaCuenta.Text = "Fecha de la cuenta:";
            // 
            // txtFechaCuenta
            // 
            txtFechaCuenta.Location = new Point(373, 114);
            txtFechaCuenta.Name = "txtFechaCuenta";
            txtFechaCuenta.Size = new Size(219, 23);
            txtFechaCuenta.TabIndex = 17;
            // 
            // btnBorrarCuenta
            // 
            btnBorrarCuenta.Location = new Point(647, 110);
            btnBorrarCuenta.Name = "btnBorrarCuenta";
            btnBorrarCuenta.Size = new Size(75, 23);
            btnBorrarCuenta.TabIndex = 32;
            btnBorrarCuenta.Text = "Borrar";
            btnBorrarCuenta.UseVisualStyleBackColor = true;
            // 
            // btnEditarCuenta
            // 
            btnEditarCuenta.Location = new Point(647, 66);
            btnEditarCuenta.Name = "btnEditarCuenta";
            btnEditarCuenta.Size = new Size(75, 23);
            btnEditarCuenta.TabIndex = 31;
            btnEditarCuenta.Text = "Editar";
            btnEditarCuenta.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrarCuenta);
            Controls.Add(btnEditarCuenta);
            Controls.Add(txtFechaCuenta);
            Controls.Add(fechaCuenta);
            Controls.Add(saldoAccount);
            Controls.Add(numAccount);
            Controls.Add(this.txtSaldo);
            Controls.Add(this.txtNumeroCuenta);
            Controls.Add(cuentasDataGridView);
            Name = "AccountForm";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)cuentasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cuentasDataGridView;
        private Label saldoAccount;
        private Label numAccount;
        private TextBox textBox2;
        private TextBox txtNumAccount;
        private Label fechaCuenta;
        private TextBox txtFecha;
        private DateTimePicker txtFechaCuenta;
        private Button btnBorrarCuenta;
        private Button btnEditarCuenta;
    }
}