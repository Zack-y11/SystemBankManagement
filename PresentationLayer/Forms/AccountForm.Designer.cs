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
            fechaCuenta = new Label();
            txtFechaCuenta = new DateTimePicker();
            saldoInicialTextBox = new TextBox();
            textBox1 = new TextBox();
            typeAccountComboBox = new ComboBox();
            typeAccountLabel = new Label();
            idClientComboBox = new ComboBox();
            label1 = new Label();
            addAccountButton = new Button();
            updateAccountButton = new Button();
            deleteAccountButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cuentasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cuentasDataGridView
            // 
            cuentasDataGridView.BackgroundColor = Color.Khaki;
            cuentasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuentasDataGridView.Location = new Point(12, 206);
            cuentasDataGridView.Name = "cuentasDataGridView";
            cuentasDataGridView.Size = new Size(776, 167);
            cuentasDataGridView.TabIndex = 0;
            // 
            // saldoAccount
            // 
            saldoAccount.AutoSize = true;
            saldoAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saldoAccount.Location = new Point(38, 54);
            saldoAccount.Name = "saldoAccount";
            saldoAccount.Size = new Size(54, 19);
            saldoAccount.TabIndex = 11;
            saldoAccount.Text = "Saldo:";
            // 
            // numAccount
            // 
            numAccount.AutoSize = true;
            numAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAccount.Location = new Point(38, 9);
            numAccount.Name = "numAccount";
            numAccount.Size = new Size(145, 19);
            numAccount.TabIndex = 10;
            numAccount.Text = "Número de cuenta:";
            // 
            // fechaCuenta
            // 
            fechaCuenta.AutoSize = true;
            fechaCuenta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaCuenta.Location = new Point(38, 93);
            fechaCuenta.Name = "fechaCuenta";
            fechaCuenta.Size = new Size(116, 19);
            fechaCuenta.TabIndex = 13;
            fechaCuenta.Text = "Fecha Apertura";
            // 
            // txtFechaCuenta
            // 
            txtFechaCuenta.Location = new Point(160, 93);
            txtFechaCuenta.Name = "txtFechaCuenta";
            txtFechaCuenta.Size = new Size(219, 23);
            txtFechaCuenta.TabIndex = 17;
            // 
            // saldoInicialTextBox
            // 
            saldoInicialTextBox.Location = new Point(160, 50);
            saldoInicialTextBox.Name = "saldoInicialTextBox";
            saldoInicialTextBox.Size = new Size(219, 23);
            saldoInicialTextBox.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 34;
            // 
            // typeAccountComboBox
            // 
            typeAccountComboBox.FormattingEnabled = true;
            typeAccountComboBox.Location = new Point(546, 5);
            typeAccountComboBox.Name = "typeAccountComboBox";
            typeAccountComboBox.Size = new Size(219, 23);
            typeAccountComboBox.TabIndex = 36;
            // 
            // typeAccountLabel
            // 
            typeAccountLabel.AutoSize = true;
            typeAccountLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeAccountLabel.Location = new Point(417, 9);
            typeAccountLabel.Name = "typeAccountLabel";
            typeAccountLabel.Size = new Size(123, 19);
            typeAccountLabel.TabIndex = 37;
            typeAccountLabel.Text = "Tipo de Cuenta:";
            // 
            // idClientComboBox
            // 
            idClientComboBox.FormattingEnabled = true;
            idClientComboBox.Location = new Point(546, 55);
            idClientComboBox.Name = "idClientComboBox";
            idClientComboBox.Size = new Size(219, 23);
            idClientComboBox.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 59);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 39;
            label1.Text = "Id Cliente";
            // 
            // addAccountButton
            // 
            addAccountButton.BackColor = Color.Goldenrod;
            addAccountButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addAccountButton.Location = new Point(139, 148);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(102, 41);
            addAccountButton.TabIndex = 40;
            addAccountButton.Text = "Agregar";
            addAccountButton.UseVisualStyleBackColor = false;
            // 
            // updateAccountButton
            // 
            updateAccountButton.BackColor = Color.Goldenrod;
            updateAccountButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateAccountButton.Location = new Point(330, 148);
            updateAccountButton.Name = "updateAccountButton";
            updateAccountButton.Size = new Size(102, 41);
            updateAccountButton.TabIndex = 41;
            updateAccountButton.Text = "Editar";
            updateAccountButton.UseVisualStyleBackColor = false;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.BackColor = Color.Goldenrod;
            deleteAccountButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteAccountButton.Location = new Point(499, 148);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(102, 41);
            deleteAccountButton.TabIndex = 42;
            deleteAccountButton.Text = "Eliminar";
            deleteAccountButton.UseVisualStyleBackColor = false;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteAccountButton);
            Controls.Add(updateAccountButton);
            Controls.Add(addAccountButton);
            Controls.Add(label1);
            Controls.Add(idClientComboBox);
            Controls.Add(typeAccountLabel);
            Controls.Add(typeAccountComboBox);
            Controls.Add(textBox1);
            Controls.Add(saldoInicialTextBox);
            Controls.Add(txtFechaCuenta);
            Controls.Add(fechaCuenta);
            Controls.Add(saldoAccount);
            Controls.Add(numAccount);
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
        private TextBox saldoInicialTextBox;
        private TextBox textBox1;
        private ComboBox typeAccountComboBox;
        private Label typeAccountLabel;
        private ComboBox idClientComboBox;
        private Label label1;
        private Button addAccountButton;
        private Button updateAccountButton;
        private Button deleteAccountButton;
    }
}