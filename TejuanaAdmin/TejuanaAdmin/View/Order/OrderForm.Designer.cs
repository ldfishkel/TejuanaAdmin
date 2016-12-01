namespace TejuanaAdmin.View.Order
{
    partial class OrderForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._orders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewButtonColumn();
            this._panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orders)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this.groupBox2);
            this._panel.Location = new System.Drawing.Point(12, 12);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(530, 336);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._orders);
            this.groupBox2.Location = new System.Drawing.Point(10, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 323);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // _orders
            // 
            this._orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ClientId,
            this.ProductName,
            this.ProductAmount,
            this.EstimatedDate,
            this.Done});
            this._orders.Location = new System.Drawing.Point(11, 19);
            this._orders.Name = "_orders";
            this._orders.RowHeadersVisible = false;
            this._orders.Size = new System.Drawing.Size(484, 291);
            this._orders.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // ClientId
            // 
            this.ClientId.FillWeight = 50F;
            this.ClientId.HeaderText = "Cliente";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.FillWeight = 150F;
            this.ProductName.HeaderText = "Nombre Producto";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // ProductAmount
            // 
            this.ProductAmount.FillWeight = 50F;
            this.ProductAmount.HeaderText = "Cantidad";
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.ReadOnly = true;
            this.ProductAmount.Width = 50;
            // 
            // EstimatedDate
            // 
            this.EstimatedDate.HeaderText = "Fecha Estimada";
            this.EstimatedDate.Name = "EstimatedDate";
            this.EstimatedDate.ReadOnly = true;
            // 
            // Done
            // 
            this.Done.FillWeight = 60F;
            this.Done.HeaderText = "Terminado";
            this.Done.Name = "Done";
            this.Done.Width = 60;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 357);
            this.Controls.Add(this._panel);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this._panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedDate;
        private System.Windows.Forms.DataGridViewButtonColumn Done;
    }
}