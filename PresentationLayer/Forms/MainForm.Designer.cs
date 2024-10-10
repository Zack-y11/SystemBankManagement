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
            clientsButton.BackColor = Color.DarkTurquoise;
            clientsButton.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            clientsButton.ForeColor = SystemColors.Window;
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
            cuentasButton.BackColor = Color.DodgerBlue;
            cuentasButton.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            cuentasButton.ForeColor = SystemColors.Window;
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
            TansactionsButton.BackColor = Color.RoyalBlue;
            TansactionsButton.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            TansactionsButton.ForeColor = SystemColors.Window;
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
            pictureBox1.BackColor = Color.Azure;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Azure;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 299);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(741, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
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