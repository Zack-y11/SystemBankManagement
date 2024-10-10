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
            dateTransaction = new DateTimePicker();
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
            transactionDataGridView.BackgroundColor = Color.LavenderBlush;
            transactionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDataGridView.GridColor = Color.Khaki;
            transactionDataGridView.Location = new Point(12, 192);
            transactionDataGridView.Name = "transactionDataGridView";
            transactionDataGridView.Size = new Size(776, 182);
            transactionDataGridView.TabIndex = 0;
            transactionDataGridView.CellClick += transactionDataGridView_CellClick;
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
            addressAccount.Font = new Font("Tahoma", 14.25F);
            addressAccount.ForeColor = Color.LavenderBlush;
            addressAccount.Location = new Point(484, 9);
            addressAccount.Name = "addressAccount";
            addressAccount.Size = new Size(67, 23);
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
            amountLabel.Font = new Font("Tahoma", 14.25F);
            amountLabel.ForeColor = Color.LavenderBlush;
            amountLabel.Location = new Point(57, 55);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(91, 23);
            amountLabel.TabIndex = 20;
            amountLabel.Text = "Cantidad:";
            // 
            // descriptionTransaction
            // 
            descriptionTransaction.AutoSize = true;
            descriptionTransaction.Font = new Font("Tahoma", 14.25F);
            descriptionTransaction.ForeColor = Color.LavenderBlush;
            descriptionTransaction.Location = new Point(47, 99);
            descriptionTransaction.Name = "descriptionTransaction";
            descriptionTransaction.Size = new Size(113, 23);
            descriptionTransaction.TabIndex = 26;
            descriptionTransaction.Text = "Descripción:";
            // 
            // dateTransaction
            // 
            dateTransaction.Location = new Point(557, 9);
            dateTransaction.Name = "dateTransaction";
            dateTransaction.Size = new Size(215, 23);
            dateTransaction.TabIndex = 27;
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Font = new Font("Tahoma", 14.25F);
            accountNumberLabel.ForeColor = Color.LavenderBlush;
            accountNumberLabel.Location = new Point(35, 12);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(176, 23);
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
            updateButton.ForeColor = SystemColors.Window;
            updateButton.Location = new Point(484, 85);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(102, 41);
            updateButton.TabIndex = 34;
            updateButton.Text = "Actualizar";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Maroon;
            deleteButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = SystemColors.Window;
            deleteButton.Location = new Point(658, 85);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(102, 41);
            deleteButton.TabIndex = 35;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
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
            Controls.Add(dateTransaction);
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
        private DateTimePicker dateTransaction;
    }
}