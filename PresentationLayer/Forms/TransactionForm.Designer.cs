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
            transactionDataGridView = new DataGridView();
            txtDescripcion = new TextBox();
            direccionAccount = new Label();
            txtCantidad = new TextBox();
            telefonoAccount = new Label();
            duiAccount = new Label();
            label1 = new Label();
            fechaTransaccion = new DateTimePicker();
            btnEditarTransaccion = new Button();
            btnBorrarTransaccion = new Button();
            tipoCuentaBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // transactionDataGridView
            // 
            transactionDataGridView.BackgroundColor = Color.Khaki;
            transactionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDataGridView.GridColor = Color.Khaki;
            transactionDataGridView.Location = new Point(12, 256);
            transactionDataGridView.Name = "transactionDataGridView";
            transactionDataGridView.Size = new Size(776, 182);
            transactionDataGridView.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(354, 201);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(215, 23);
            txtDescripcion.TabIndex = 25;
            // 
            // direccionAccount
            // 
            direccionAccount.AutoSize = true;
            direccionAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionAccount.Location = new Point(255, 153);
            direccionAccount.Name = "direccionAccount";
            direccionAccount.Size = new Size(55, 19);
            direccionAccount.TabIndex = 24;
            direccionAccount.Text = "Fecha:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(354, 96);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(215, 23);
            txtCantidad.TabIndex = 23;
            // 
            // telefonoAccount
            // 
            telefonoAccount.AutoSize = true;
            telefonoAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoAccount.Location = new Point(247, 100);
            telefonoAccount.Name = "telefonoAccount";
            telefonoAccount.Size = new Size(77, 19);
            telefonoAccount.TabIndex = 20;
            telefonoAccount.Text = "Cantidad:";
            // 
            // duiAccount
            // 
            duiAccount.AutoSize = true;
            duiAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duiAccount.Location = new Point(263, 28);
            duiAccount.Name = "duiAccount";
            duiAccount.Size = new Size(47, 19);
            duiAccount.TabIndex = 19;
            duiAccount.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 201);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 26;
            label1.Text = "Descripción:";
            // 
            // fechaTransaccion
            // 
            fechaTransaccion.Location = new Point(354, 153);
            fechaTransaccion.Name = "fechaTransaccion";
            fechaTransaccion.Size = new Size(215, 23);
            fechaTransaccion.TabIndex = 27;
            // 
            // btnEditarTransaccion
            // 
            btnEditarTransaccion.Location = new Point(621, 68);
            btnEditarTransaccion.Name = "btnEditarTransaccion";
            btnEditarTransaccion.Size = new Size(75, 23);
            btnEditarTransaccion.TabIndex = 29;
            btnEditarTransaccion.Text = "Editar";
            btnEditarTransaccion.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTransaccion
            // 
            btnBorrarTransaccion.Location = new Point(621, 149);
            btnBorrarTransaccion.Name = "btnBorrarTransaccion";
            btnBorrarTransaccion.Size = new Size(75, 23);
            btnBorrarTransaccion.TabIndex = 30;
            btnBorrarTransaccion.Text = "Borrar";
            btnBorrarTransaccion.UseVisualStyleBackColor = true;
            // 
            // tipoCuentaBox
            // 
            tipoCuentaBox.FormattingEnabled = true;
            tipoCuentaBox.Location = new Point(354, 29);
            tipoCuentaBox.Name = "tipoCuentaBox";
            tipoCuentaBox.Size = new Size(215, 23);
            tipoCuentaBox.TabIndex = 31;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(tipoCuentaBox);
            Controls.Add(btnBorrarTransaccion);
            Controls.Add(btnEditarTransaccion);
            Controls.Add(fechaTransaccion);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(direccionAccount);
            Controls.Add(txtCantidad);
            Controls.Add(telefonoAccount);
            Controls.Add(duiAccount);
            Controls.Add(transactionDataGridView);
            Name = "TransactionForm";
            Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transactionDataGridView;
        private TextBox txtDescripcion;
        private Label direccionAccount;
        private TextBox txtCantidad;
        private Label telefonoAccount;
        private Label duiAccount;
        private Label label1;
        private DateTimePicker fechaTransaccion;
        private Button btnEditarTransaccion;
        private Button btnBorrarTransaccion;
        private ComboBox tipoCuentaBox;
    }
}