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
            DeleteButton = new Button();
            updateButton = new Button();
            accountTextBox = new TextBox();
            accountLabel = new Label();
            transactionDatePicker = new DateTimePicker();
            descriptionLabel = new Label();
            txtDescripcion = new TextBox();
            dateLabel = new Label();
            txtCantidad = new TextBox();
            telefonoAccount = new Label();
            transactionDataGridView = new DataGridView();
            historyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Goldenrod;
            DeleteButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(661, 60);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 41);
            DeleteButton.TabIndex = 46;
            DeleteButton.Text = "Retirar";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Goldenrod;
            updateButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(477, 60);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(102, 41);
            updateButton.TabIndex = 45;
            updateButton.Text = "Depositar";
            updateButton.UseVisualStyleBackColor = false;
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
            accountLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountLabel.Location = new Point(39, 7);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(142, 19);
            accountLabel.TabIndex = 43;
            accountLabel.Text = "Numero de Cuenta";
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
            descriptionLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(39, 135);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(96, 19);
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
            dateLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(477, 7);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(55, 19);
            dateLabel.TabIndex = 39;
            dateLabel.Text = "Fecha:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(201, 67);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(215, 23);
            txtCantidad.TabIndex = 38;
            // 
            // telefonoAccount
            // 
            telefonoAccount.AutoSize = true;
            telefonoAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoAccount.Location = new Point(39, 71);
            telefonoAccount.Name = "telefonoAccount";
            telefonoAccount.Size = new Size(77, 19);
            telefonoAccount.TabIndex = 37;
            telefonoAccount.Text = "Cantidad:";
            // 
            // transactionDataGridView
            // 
            transactionDataGridView.BackgroundColor = Color.Khaki;
            transactionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDataGridView.GridColor = Color.Khaki;
            transactionDataGridView.Location = new Point(12, 189);
            transactionDataGridView.Name = "transactionDataGridView";
            transactionDataGridView.Size = new Size(776, 182);
            transactionDataGridView.TabIndex = 36;
            // 
            // historyButton
            // 
            historyButton.BackColor = Color.Goldenrod;
            historyButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyButton.Location = new Point(477, 119);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(286, 41);
            historyButton.TabIndex = 47;
            historyButton.Text = "Historial";
            historyButton.UseVisualStyleBackColor = false;
            historyButton.Click += historyButton_Click;
            // 
            // ClientTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(historyButton);
            Controls.Add(DeleteButton);
            Controls.Add(updateButton);
            Controls.Add(accountTextBox);
            Controls.Add(accountLabel);
            Controls.Add(transactionDatePicker);
            Controls.Add(descriptionLabel);
            Controls.Add(txtDescripcion);
            Controls.Add(dateLabel);
            Controls.Add(txtCantidad);
            Controls.Add(telefonoAccount);
            Controls.Add(transactionDataGridView);
            Name = "ClientTransaction";
            Text = "ClientTransaction";
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteButton;
        private Button updateButton;
        private TextBox accountTextBox;
        private Label accountLabel;
        private DateTimePicker transactionDatePicker;
        private Label descriptionLabel;
        private TextBox txtDescripcion;
        private Label dateLabel;
        private TextBox txtCantidad;
        private Label telefonoAccount;
        private DataGridView transactionDataGridView;
        private Button historyButton;
    }
}