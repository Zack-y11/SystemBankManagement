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
            components = new System.ComponentModel.Container();
            clientsDataGridView = new DataGridView();
            btnDeteleClient = new Button();
            txtAddress = new TextBox();
            addressClientAccount = new Label();
            txtPhoneClient = new TextBox();
            txtDui = new TextBox();
            txtName = new TextBox();
            phoneClientAccount = new Label();
            duiClientAccount = new Label();
            nameClientAccount = new Label();
            btnEditClient = new Button();
            addClientButton = new Button();
            errorClient = new ErrorProvider(components);
            txtPassword = new TextBox();
            passwordClient = new Label();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorClient).BeginInit();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.BackgroundColor = Color.Khaki;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.GridColor = Color.Khaki;
            clientsDataGridView.Location = new Point(12, 274);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.Size = new Size(776, 150);
            clientsDataGridView.TabIndex = 0;
            // 
            // btnDeteleClient
            // 
            btnDeteleClient.BackColor = Color.Goldenrod;
            btnDeteleClient.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeteleClient.Location = new Point(582, 161);
            btnDeteleClient.Name = "btnDeteleClient";
            btnDeteleClient.Size = new Size(102, 41);
            btnDeteleClient.TabIndex = 18;
            btnDeteleClient.Text = "Borrar";
            btnDeteleClient.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(322, 173);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 23);
            txtAddress.TabIndex = 17;
            // 
            // addressClientAccount
            // 
            addressClientAccount.AutoSize = true;
            addressClientAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressClientAccount.Location = new Point(215, 173);
            addressClientAccount.Name = "addressClientAccount";
            addressClientAccount.Size = new Size(80, 19);
            addressClientAccount.TabIndex = 16;
            addressClientAccount.Text = "Dirección:";
            // 
            // txtPhoneClient
            // 
            txtPhoneClient.Location = new Point(322, 120);
            txtPhoneClient.Name = "txtPhoneClient";
            txtPhoneClient.Size = new Size(215, 23);
            txtPhoneClient.TabIndex = 15;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(322, 75);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(215, 23);
            txtDui.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Location = new Point(322, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(215, 23);
            txtName.TabIndex = 13;
            // 
            // phoneClientAccount
            // 
            phoneClientAccount.AutoSize = true;
            phoneClientAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneClientAccount.Location = new Point(160, 120);
            phoneClientAccount.Name = "phoneClientAccount";
            phoneClientAccount.Size = new Size(156, 19);
            phoneClientAccount.TabIndex = 12;
            phoneClientAccount.Text = "Número de teléfono:";
            // 
            // duiClientAccount
            // 
            duiClientAccount.AutoSize = true;
            duiClientAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duiClientAccount.Location = new Point(230, 74);
            duiClientAccount.Name = "duiClientAccount";
            duiClientAccount.Size = new Size(43, 19);
            duiClientAccount.TabIndex = 11;
            duiClientAccount.Text = "DUI:";
            // 
            // nameClientAccount
            // 
            nameClientAccount.AutoSize = true;
            nameClientAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameClientAccount.Location = new Point(215, 29);
            nameClientAccount.Name = "nameClientAccount";
            nameClientAccount.Size = new Size(72, 19);
            nameClientAccount.TabIndex = 10;
            nameClientAccount.Text = "Nombre:";
            // 
            // btnEditClient
            // 
            btnEditClient.BackColor = Color.Goldenrod;
            btnEditClient.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditClient.Location = new Point(582, 98);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(102, 41);
            btnEditClient.TabIndex = 19;
            btnEditClient.Text = "Editar";
            btnEditClient.UseVisualStyleBackColor = false;
            // 
            // addClientButton
            // 
            addClientButton.BackColor = Color.Goldenrod;
            addClientButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addClientButton.Location = new Point(582, 29);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(102, 41);
            addClientButton.TabIndex = 20;
            addClientButton.Text = "Agregar";
            addClientButton.UseVisualStyleBackColor = false;
            // 
            // errorClient
            // 
            errorClient.ContainerControl = this;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(322, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(215, 23);
            txtPassword.TabIndex = 22;
            // 
            // passwordClient
            // 
            passwordClient.AutoSize = true;
            passwordClient.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordClient.Location = new Point(215, 219);
            passwordClient.Name = "passwordClient";
            passwordClient.Size = new Size(94, 19);
            passwordClient.TabIndex = 21;
            passwordClient.Text = "Contraseña:";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(passwordClient);
            Controls.Add(addClientButton);
            Controls.Add(btnEditClient);
            Controls.Add(btnDeteleClient);
            Controls.Add(txtAddress);
            Controls.Add(addressClientAccount);
            Controls.Add(txtPhoneClient);
            Controls.Add(txtDui);
            Controls.Add(txtName);
            Controls.Add(phoneClientAccount);
            Controls.Add(duiClientAccount);
            Controls.Add(nameClientAccount);
            Controls.Add(clientsDataGridView);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView clientsDataGridView;
        private Button btnDeteleClient;
        private TextBox txtAddress;
        private Label addressClientAccount;
        private TextBox txtPhoneClient;
        private TextBox txtDui;
        private TextBox txtName;
        private Label phoneClientAccount;
        private Label duiClientAccount;
        private Label nameClientAccount;
        private Button btnEditClient;
        private Button addClientButton;
        private ErrorProvider errorClient;
        private TextBox txtPassword;
        private Label passwordClient;
    }
}