namespace PresentationLayer.Forms
{
    partial class ClientTransaction
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
            withdrawlButton = new Button();
            depositButton = new Button();
            accountTextBox = new TextBox();
            accountLabel = new Label();
            transactionDatePicker = new DateTimePicker();
            descriptionLabel = new Label();
            txtDescripcion = new TextBox();
            dateLabel = new Label();
            txtAmount = new TextBox();
            telefonoAccount = new Label();
            transactionDataGridView = new DataGridView();
            historyButton = new Button();
            errorClientTransaction = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorClientTransaction).BeginInit();
            SuspendLayout();
            // 
            // withdrawlButton
            // 
            withdrawlButton.BackColor = Color.LimeGreen;
            withdrawlButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawlButton.ForeColor = SystemColors.Window;
            withdrawlButton.Location = new Point(661, 60);
            withdrawlButton.Name = "withdrawlButton";
            withdrawlButton.Size = new Size(102, 41);
            withdrawlButton.TabIndex = 46;
            withdrawlButton.Text = "Retirar";
            withdrawlButton.UseVisualStyleBackColor = false;
            withdrawlButton.Click += withdrawlButton_Click;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.FromArgb(0, 192, 192);
            depositButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.ForeColor = SystemColors.Window;
            depositButton.Location = new Point(477, 60);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(102, 41);
            depositButton.TabIndex = 45;
            depositButton.Text = "Depositar";
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(201, 3);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(215, 23);
            accountTextBox.TabIndex = 44;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            accountLabel.ForeColor = SystemColors.Window;
            accountLabel.Location = new Point(28, 7);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(167, 19);
            accountLabel.TabIndex = 43;
            accountLabel.Text = "Numero de Cuenta:";
            // 
            // transactionDatePicker
            // 
            transactionDatePicker.Location = new Point(548, 5);
            transactionDatePicker.Name = "transactionDatePicker";
            transactionDatePicker.Size = new Size(215, 23);
            transactionDatePicker.TabIndex = 42;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            descriptionLabel.ForeColor = SystemColors.Window;
            descriptionLabel.Location = new Point(39, 135);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(108, 19);
            descriptionLabel.TabIndex = 41;
            descriptionLabel.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(201, 131);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(215, 23);
            txtDescripcion.TabIndex = 40;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = SystemColors.Window;
            dateLabel.Location = new Point(477, 7);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(62, 19);
            dateLabel.TabIndex = 39;
            dateLabel.Text = "Fecha:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(201, 67);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(215, 23);
            txtAmount.TabIndex = 38;
            // 
            // telefonoAccount
            // 
            telefonoAccount.AutoSize = true;
            telefonoAccount.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            telefonoAccount.ForeColor = SystemColors.Window;
            telefonoAccount.Location = new Point(39, 71);
            telefonoAccount.Name = "telefonoAccount";
            telefonoAccount.Size = new Size(88, 19);
            telefonoAccount.TabIndex = 37;
            telefonoAccount.Text = "Cantidad:";
            // 
            // transactionDataGridView
            // 
            transactionDataGridView.BackgroundColor = Color.LavenderBlush;
            transactionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDataGridView.GridColor = Color.Khaki;
            transactionDataGridView.Location = new Point(12, 189);
            transactionDataGridView.Name = "transactionDataGridView";
            transactionDataGridView.Size = new Size(776, 182);
            transactionDataGridView.TabIndex = 36;
            // 
            // historyButton
            // 
            historyButton.BackColor = Color.RoyalBlue;
            historyButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyButton.ForeColor = SystemColors.Window;
            historyButton.Location = new Point(477, 119);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(286, 41);
            historyButton.TabIndex = 47;
            historyButton.Text = "Historial";
            historyButton.UseVisualStyleBackColor = false;
            historyButton.Click += historyButton_Click;
            // 
            // errorClientTransaction
            // 
            errorClientTransaction.ContainerControl = this;
            // 
            // ClientTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(historyButton);
            Controls.Add(withdrawlButton);
            Controls.Add(depositButton);
            Controls.Add(accountTextBox);
            Controls.Add(accountLabel);
            Controls.Add(transactionDatePicker);
            Controls.Add(descriptionLabel);
            Controls.Add(txtDescripcion);
            Controls.Add(dateLabel);
            Controls.Add(txtAmount);
            Controls.Add(telefonoAccount);
            Controls.Add(transactionDataGridView);
            Name = "ClientTransaction";
            Text = "ClientTransaction";
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorClientTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button withdrawlButton;
        private Button depositButton;
        private TextBox accountTextBox;
        private Label accountLabel;
        private DateTimePicker transactionDatePicker;
        private Label descriptionLabel;
        private TextBox txtDescripcion;
        private Label dateLabel;
        private TextBox txtAmount;
        private Label telefonoAccount;
        private DataGridView transactionDataGridView;
        private Button historyButton;
        private ErrorProvider errorClientTransaction;
    }
}