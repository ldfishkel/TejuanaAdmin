﻿namespace TejuanaAdmin.Functionalities.Stock
{
    partial class StockForm
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
            this._panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Location = new System.Drawing.Point(16, 22);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(255, 228);
            this._panel.TabIndex = 0;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this._panel);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
    }
}