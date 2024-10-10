namespace PresentationLayer.Forms
{
    partial class TransactionForm
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
            transactionDataGridView = new DataGridView();
            descriptionTextBox = new TextBox();
            addressAccount = new Label();
            amountTextBox = new TextBox();
            amountLabel = new Label();
            descriptionTransaction = new Label();
            dateTransaccion = new DateTimePicker();
            accountNumberLabel = new Label();
            accountNumberTextBox = new TextBox();
            updateButton = new Button();
            deleteButton = new Button();
            errorTransaction = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorTransaction).BeginInit();
            SuspendLayout();
            // 
            // transactionDataGridView
            // 
            transactionDataGridView.BackgroundColor = Color.PowderBlue;
            transactionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDataGridView.GridColor = Color.Khaki;
            transactionDataGridView.Location = new Point(12, 192);
            transactionDataGridView.Name = "transactionDataGridView";
            transactionDataGridView.Size = new Size(776, 182);
            transactionDataGridView.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(212, 103);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(215, 23);
            descriptionTextBox.TabIndex = 25;
            // 
            // addressAccount
            // 
            addressAccount.AutoSize = true;
            addressAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressAccount.Location = new Point(81, 147);
            addressAccount.Name = "addressAccount";
            addressAccount.Size = new Size(55, 19);
            addressAccount.TabIndex = 24;
            addressAccount.Text = "Fecha:";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(212, 59);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(215, 23);
            amountTextBox.TabIndex = 23;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(72, 59);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(77, 19);
            amountLabel.TabIndex = 20;
            amountLabel.Text = "Cantidad:";
            // 
            // descriptionTransaction
            // 
            descriptionTransaction.AutoSize = true;
            descriptionTransaction.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTransaction.Location = new Point(62, 103);
            descriptionTransaction.Name = "descriptionTransaction";
            descriptionTransaction.Size = new Size(96, 19);
            descriptionTransaction.TabIndex = 26;
            descriptionTransaction.Text = "Descripción:";
            // 
            // dateTransaccion
            // 
            dateTransaccion.Location = new Point(212, 147);
            dateTransaccion.Name = "dateTransaccion";
            dateTransaccion.Size = new Size(215, 23);
            dateTransaccion.TabIndex = 27;
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNumberLabel.Location = new Point(50, 16);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(148, 19);
            accountNumberLabel.TabIndex = 32;
            accountNumberLabel.Text = "Número de Cuenta:";
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Location = new Point(212, 12);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(215, 23);
            accountNumberTextBox.TabIndex = 33;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.LimeGreen;
            updateButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(492, 59);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(102, 41);
            updateButton.TabIndex = 34;
            updateButton.Text = "Actualizar";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(192, 0, 0);
            deleteButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(660, 59);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(102, 41);
            deleteButton.TabIndex = 35;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // errorTransaction
            // 
            errorTransaction.ContainerControl = this;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(accountNumberTextBox);
            Controls.Add(accountNumberLabel);
            Controls.Add(dateTransaccion);
            Controls.Add(descriptionTransaction);
            Controls.Add(descriptionTextBox);
            Controls.Add(addressAccount);
            Controls.Add(amountTextBox);
            Controls.Add(amountLabel);
            Controls.Add(transactionDataGridView);
            Name = "TransactionForm";
            Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transactionDataGridView;
        private TextBox descriptionTextBox;
        private Label addressAccount;
        private TextBox amountTextBox;
        private Label amountLabel;
        private Label descriptionTransaction;
        private DateTimePicker dateTransaccion;
        private ComboBox comboBox1;
        private Label accountNumberLabel;
        private TextBox accountNumberTextBox;
        private Button updateButton;
        private Button deleteButton;
        private ErrorProvider errorTransaction;
    }
}