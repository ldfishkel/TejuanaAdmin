namespace TejuanaAdmin.Functionalities.Shipping
{
    partial class ShippingForm
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
            this._shippings = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._addProductBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Shipped = new System.Windows.Forms.DataGridViewButtonColumn();
            this._panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._shippings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this.groupBox2);
            this._panel.Controls.Add(this.groupBox1);
            this._panel.Location = new System.Drawing.Point(12, 12);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(615, 382);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._shippings);
            this.groupBox2.Location = new System.Drawing.Point(9, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 328);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // _shippings
            // 
            this._shippings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._shippings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Client,
            this.Address,
            this.ZipCode,
            this.Status,
            this.Details,
            this.Shipped});
            this._shippings.Location = new System.Drawing.Point(11, 19);
            this._shippings.Name = "_shippings";
            this._shippings.RowHeadersVisible = false;
            this._shippings.Size = new System.Drawing.Size(572, 291);
            this._shippings.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this._addProductBtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // _addProductBtn
            // 
            this._addProductBtn.Location = new System.Drawing.Point(413, 14);
            this._addProductBtn.Name = "_addProductBtn";
            this._addProductBtn.Size = new System.Drawing.Size(170, 21);
            this._addProductBtn.TabIndex = 1;
            this._addProductBtn.Text = "Enviados";
            this._addProductBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Todos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "No Enviados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // Client
            // 
            this.Client.FillWeight = 50F;
            this.Client.HeaderText = "Cliente";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 50;
            // 
            // Address
            // 
            this.Address.FillWeight = 250F;
            this.Address.HeaderText = "Direccion";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 250;
            // 
            // ZipCode
            // 
            this.ZipCode.FillWeight = 50F;
            this.ZipCode.HeaderText = "C.P.";
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ReadOnly = true;
            this.ZipCode.Width = 50;
            // 
            // Status
            // 
            this.Status.FillWeight = 50F;
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // Details
            // 
            this.Details.FillWeight = 50F;
            this.Details.HeaderText = "Detalle";
            this.Details.Name = "Details";
            this.Details.Width = 50;
            // 
            // Shipped
            // 
            this.Shipped.FillWeight = 50F;
            this.Shipped.HeaderText = "Enviado";
            this.Shipped.Name = "Shipped";
            this.Shipped.Width = 50;
            // 
            // ShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 405);
            this.Controls.Add(this._panel);
            this.Name = "ShippingForm";
            this.Text = "ShippingForm";
            this._panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._shippings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _shippings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button _addProductBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Shipped;
    }
}