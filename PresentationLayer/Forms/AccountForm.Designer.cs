namespace PresentationLayer.Forms
{
    partial class AccountForm
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
            cuentasDataGridView = new DataGridView();
            btnMostrar = new Button();
            saldoAccount = new Label();
            numAccount = new Label();
            textBox2 = new TextBox();
            txtNumAccount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)cuentasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cuentasDataGridView
            // 
            cuentasDataGridView.BackgroundColor = Color.Khaki;
            cuentasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuentasDataGridView.Location = new Point(12, 159);
            cuentasDataGridView.Name = "cuentasDataGridView";
            cuentasDataGridView.Size = new Size(776, 197);
            cuentasDataGridView.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Goldenrod;
            btnMostrar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrar.Location = new Point(638, 81);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(90, 33);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            // 
            // saldoAccount
            // 
            saldoAccount.AutoSize = true;
            saldoAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saldoAccount.Location = new Point(257, 104);
            saldoAccount.Name = "saldoAccount";
            saldoAccount.Size = new Size(54, 19);
            saldoAccount.TabIndex = 11;
            saldoAccount.Text = "Saldo:";
            // 
            // numAccount
            // 
            numAccount.AutoSize = true;
            numAccount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAccount.Location = new Point(218, 71);
            numAccount.Name = "numAccount";
            numAccount.Size = new Size(145, 19);
            numAccount.TabIndex = 10;
            numAccount.Text = "Número de cuenta:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(369, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 9;
            // 
            // txtNumAccount
            // 
            txtNumAccount.Location = new Point(369, 67);
            txtNumAccount.Name = "txtNumAccount";
            txtNumAccount.Size = new Size(219, 23);
            txtNumAccount.TabIndex = 8;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(saldoAccount);
            Controls.Add(numAccount);
            Controls.Add(textBox2);
            Controls.Add(txtNumAccount);
            Controls.Add(cuentasDataGridView);
            Name = "AccountForm";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)cuentasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cuentasDataGridView;
        private Button btnMostrar;
        private Label saldoAccount;
        private Label numAccount;
        private TextBox textBox2;
        private TextBox txtNumAccount;
    }
}