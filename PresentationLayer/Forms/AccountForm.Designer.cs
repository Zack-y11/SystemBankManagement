﻿namespace PresentationLayer.Forms
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
            ((System.ComponentModel.ISupportInitialize)cuentasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cuentasDataGridView
            // 
            cuentasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuentasDataGridView.Location = new Point(12, 159);
            cuentasDataGridView.Name = "cuentasDataGridView";
            cuentasDataGridView.Size = new Size(776, 197);
            cuentasDataGridView.TabIndex = 0;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cuentasDataGridView);
            Name = "AccountForm";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)cuentasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView cuentasDataGridView;
    }
}