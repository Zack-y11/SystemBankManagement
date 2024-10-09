namespace PresentationLayer.Forms
{
    partial class ClientForm
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
            clientsDataGridView = new DataGridView();
            btnBorrarCliente = new Button();
            txtDireccion = new TextBox();
            direccionAccount = new Label();
            txtTelefono = new TextBox();
            txtDui = new TextBox();
            txtNombre = new TextBox();
            telefonoAccount = new Label();
            duiAccount = new Label();
            nameAcoount = new Label();
            btnEditarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.BackgroundColor = Color.Khaki;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.GridColor = Color.Khaki;
            clientsDataGridView.Location = new Point(12, 227);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.Size = new Size(776, 150);
            clientsDataGridView.TabIndex = 0;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.BackColor = Color.Goldenrod;
            btnBorrarCliente.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarCliente.Location = new Point(582, 142);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(102, 41);
            btnBorrarCliente.TabIndex = 18;
            btnBorrarCliente.Text = "Borrar";
            btnBorrarCliente.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(322, 173);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(215, 23);
            txtDireccion.TabIndex = 17;
            // 
            // direccionAccount
            // 
            direccionAccount.AutoSize = true;
            direccionAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionAccount.Location = new Point(215, 173);
            direccionAccount.Name = "direccionAccount";
            direccionAccount.Size = new Size(80, 19);
            direccionAccount.TabIndex = 16;
            direccionAccount.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(322, 120);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 23);
            txtTelefono.TabIndex = 15;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(322, 75);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(215, 23);
            txtDui.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(322, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 13;
            // 
            // telefonoAccount
            // 
            telefonoAccount.AutoSize = true;
            telefonoAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoAccount.Location = new Point(160, 120);
            telefonoAccount.Name = "telefonoAccount";
            telefonoAccount.Size = new Size(156, 19);
            telefonoAccount.TabIndex = 12;
            telefonoAccount.Text = "Número de teléfono:";
            // 
            // duiAccount
            // 
            duiAccount.AutoSize = true;
            duiAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duiAccount.Location = new Point(230, 74);
            duiAccount.Name = "duiAccount";
            duiAccount.Size = new Size(43, 19);
            duiAccount.TabIndex = 11;
            duiAccount.Text = "DUI:";
            // 
            // nameAcoount
            // 
            nameAcoount.AutoSize = true;
            nameAcoount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameAcoount.Location = new Point(215, 29);
            nameAcoount.Name = "nameAcoount";
            nameAcoount.Size = new Size(72, 19);
            nameAcoount.TabIndex = 10;
            nameAcoount.Text = "Nombre:";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.Goldenrod;
            btnEditarCliente.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCliente.Location = new Point(582, 30);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(102, 41);
            btnEditarCliente.TabIndex = 19;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnBorrarCliente);
            Controls.Add(txtDireccion);
            Controls.Add(direccionAccount);
            Controls.Add(txtTelefono);
            Controls.Add(txtDui);
            Controls.Add(txtNombre);
            Controls.Add(telefonoAccount);
            Controls.Add(duiAccount);
            Controls.Add(nameAcoount);
            Controls.Add(clientsDataGridView);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView clientsDataGridView;
        private Button btnBorrarCliente;
        private TextBox txtDireccion;
        private Label direccionAccount;
        private TextBox txtTelefono;
        private TextBox txtDui;
        private TextBox txtNombre;
        private Label telefonoAccount;
        private Label duiAccount;
        private Label nameAcoount;
        private Button btnEditarCliente;
    }
}