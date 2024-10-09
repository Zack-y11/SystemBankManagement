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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            clientsButton = new Button();
            cuentasButton = new Button();
            TansactionsButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // clientsButton
            // 
            clientsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clientsButton.BackColor = Color.Goldenrod;
            clientsButton.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientsButton.Location = new Point(12, 168);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(204, 69);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "Ver Clientes";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // cuentasButton
            // 
            cuentasButton.BackColor = Color.Goldenrod;
            cuentasButton.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuentasButton.Location = new Point(299, 168);
            cuentasButton.Name = "cuentasButton";
            cuentasButton.Size = new Size(204, 69);
            cuentasButton.TabIndex = 1;
            cuentasButton.Text = "Ver Cuentas";
            cuentasButton.UseVisualStyleBackColor = false;
            cuentasButton.Click += cuentasButton_Click;
            // 
            // TansactionsButton
            // 
            TansactionsButton.BackColor = Color.Goldenrod;
            TansactionsButton.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TansactionsButton.Location = new Point(584, 168);
            TansactionsButton.Name = "TansactionsButton";
            TansactionsButton.Size = new Size(204, 69);
            TansactionsButton.TabIndex = 2;
            TansactionsButton.Text = "Ver Transacciones";
            TansactionsButton.UseVisualStyleBackColor = false;
            TansactionsButton.Click += TansactionsButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(336, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(TansactionsButton);
            Controls.Add(cuentasButton);
            Controls.Add(clientsButton);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button clientsButton;
        private Button cuentasButton;
        private Button TansactionsButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}