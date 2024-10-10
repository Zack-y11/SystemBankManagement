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
            components = new System.ComponentModel.Container();
            accountDataGridView = new DataGridView();
            saldoAccount = new Label();
            numAccount = new Label();
            DateAccount = new Label();
            txtDateAccount = new DateTimePicker();
            txtSaldoAccount = new TextBox();
            txtnumberAccount = new TextBox();
            typeAccountComboBox = new ComboBox();
            typeAccountLabel = new Label();
            idClientComboBox = new ComboBox();
            clientAccount = new Label();
            addAccountButton = new Button();
            updateAccountButton = new Button();
            deleteAccountButton = new Button();
            errorAccount = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)accountDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorAccount).BeginInit();
            SuspendLayout();
            // 
            // accountDataGridView
            // 
            accountDataGridView.BackgroundColor = Color.Khaki;
            accountDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountDataGridView.Location = new Point(12, 206);
            accountDataGridView.Name = "accountDataGridView";
            accountDataGridView.Size = new Size(776, 167);
            accountDataGridView.TabIndex = 0;
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
            // DateAccount
            // 
            DateAccount.AutoSize = true;
            DateAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateAccount.Location = new Point(38, 93);
            DateAccount.Name = "DateAccount";
            DateAccount.Size = new Size(116, 19);
            DateAccount.TabIndex = 13;
            DateAccount.Text = "Fecha Apertura";
            // 
            // txtDateAccount
            // 
            txtDateAccount.Location = new Point(160, 93);
            txtDateAccount.Name = "txtDateAccount";
            txtDateAccount.Size = new Size(219, 23);
            txtDateAccount.TabIndex = 17;
            // 
            // txtSaldoAccount
            // 
            txtSaldoAccount.Location = new Point(160, 50);
            txtSaldoAccount.Name = "txtSaldoAccount";
            txtSaldoAccount.Size = new Size(219, 23);
            txtSaldoAccount.TabIndex = 33;
            // 
            // txtnumberAccount
            // 
            txtnumberAccount.Location = new Point(189, 9);
            txtnumberAccount.Name = "txtnumberAccount";
            txtnumberAccount.Size = new Size(190, 23);
            txtnumberAccount.TabIndex = 34;
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
            // clientAccount
            // 
            clientAccount.AutoSize = true;
            clientAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientAccount.Location = new Point(417, 59);
            clientAccount.Name = "clientAccount";
            clientAccount.Size = new Size(77, 19);
            clientAccount.TabIndex = 39;
            clientAccount.Text = "Id Cliente";
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
            deleteAccountButton.Location = new Point(517, 148);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(102, 41);
            deleteAccountButton.TabIndex = 42;
            deleteAccountButton.Text = "Eliminar";
            deleteAccountButton.UseVisualStyleBackColor = false;
            // 
            // errorAccount
            // 
            errorAccount.ContainerControl = this;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteAccountButton);
            Controls.Add(updateAccountButton);
            Controls.Add(addAccountButton);
            Controls.Add(clientAccount);
            Controls.Add(idClientComboBox);
            Controls.Add(typeAccountLabel);
            Controls.Add(typeAccountComboBox);
            Controls.Add(txtnumberAccount);
            Controls.Add(txtSaldoAccount);
            Controls.Add(txtDateAccount);
            Controls.Add(DateAccount);
            Controls.Add(saldoAccount);
            Controls.Add(numAccount);
            Controls.Add(accountDataGridView);
            Name = "AccountForm";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)accountDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView accountDataGridView;
        private Label saldoAccount;
        private Label numAccount;
        private TextBox textBox2;
        private TextBox txtNumAccount;
        private Label DateAccount;
        private TextBox txtFecha;
        private DateTimePicker txtDateAccount;
        private TextBox txtSaldoAccount;
        private TextBox txtnumberAccount;
        private ComboBox typeAccountComboBox;
        private Label typeAccountLabel;
        private ComboBox idClientComboBox;
        private Label clientAccount;
        private Button addAccountButton;
        private Button updateAccountButton;
        private Button deleteAccountButton;
        private ErrorProvider errorAccount;
    }
}