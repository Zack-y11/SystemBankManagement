namespace PresentationLayer.Forms
{
    partial class MainForm
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
            clientsButton = new Button();
            cuentasButton = new Button();
            TansactionsButton = new Button();
            SuspendLayout();
            // 
            // clientsButton
            // 
            clientsButton.Location = new Point(12, 168);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(204, 69);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "Ver Clientes";
            clientsButton.UseVisualStyleBackColor = true;
            clientsButton.Click += clientsButton_Click;
            // 
            // cuentasButton
            // 
            cuentasButton.Location = new Point(314, 168);
            cuentasButton.Name = "cuentasButton";
            cuentasButton.Size = new Size(204, 69);
            cuentasButton.TabIndex = 1;
            cuentasButton.Text = "Ver Cuentas";
            cuentasButton.UseVisualStyleBackColor = true;
            cuentasButton.Click += cuentasButton_Click;
            // 
            // TansactionsButton
            // 
            TansactionsButton.Location = new Point(584, 168);
            TansactionsButton.Name = "TansactionsButton";
            TansactionsButton.Size = new Size(204, 69);
            TansactionsButton.TabIndex = 2;
            TansactionsButton.Text = "Ver Transacciones";
            TansactionsButton.UseVisualStyleBackColor = true;
            TansactionsButton.Click += TansactionsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TansactionsButton);
            Controls.Add(cuentasButton);
            Controls.Add(clientsButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button clientsButton;
        private Button cuentasButton;
        private Button TansactionsButton;
    }
}