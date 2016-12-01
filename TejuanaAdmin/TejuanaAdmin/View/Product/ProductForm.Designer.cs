namespace TejuanaAdmin.Functionalities
{
    partial class ProductForm
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
            this._products = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._addProductBtn = new System.Windows.Forms.Button();
            this._productype = new System.Windows.Forms.ComboBox();
            this._panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._products)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this.groupBox2);
            this._panel.Controls.Add(this.groupBox1);
            this._panel.Location = new System.Drawing.Point(12, 12);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(714, 402);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._products);
            this.groupBox2.Location = new System.Drawing.Point(10, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // _products
            // 
            this._products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.name,
            this.price,
            this.stock,
            this.edit});
            this._products.Location = new System.Drawing.Point(11, 19);
            this._products.Name = "_products";
            this._products.RowHeadersVisible = false;
            this._products.Size = new System.Drawing.Size(673, 291);
            this._products.TabIndex = 0;
            this._products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // type
            // 
            this.type.FillWeight = 200F;
            this.type.HeaderText = "Tipo";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 200;
            // 
            // name
            // 
            this.name.FillWeight = 250F;
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // price
            // 
            this.price.FillWeight = 50F;
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 50;
            // 
            // stock
            // 
            this.stock.FillWeight = 50F;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 50;
            // 
            // edit
            // 
            this.edit.FillWeight = 50F;
            this.edit.HeaderText = "Editar";
            this.edit.Name = "edit";
            this.edit.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._addProductBtn);
            this.groupBox1.Controls.Add(this._productype);
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // _addProductBtn
            // 
            this._addProductBtn.Location = new System.Drawing.Point(348, 19);
            this._addProductBtn.Name = "_addProductBtn";
            this._addProductBtn.Size = new System.Drawing.Size(336, 21);
            this._addProductBtn.TabIndex = 1;
            this._addProductBtn.Text = "Agregar Producto Nuevo";
            this._addProductBtn.UseVisualStyleBackColor = true;
            this._addProductBtn.Click += new System.EventHandler(this.AddProductClick);
            // 
            // _productype
            // 
            this._productype.FormattingEnabled = true;
            this._productype.Location = new System.Drawing.Point(11, 20);
            this._productype.Name = "_productype";
            this._productype.Size = new System.Drawing.Size(331, 21);
            this._productype.TabIndex = 0;
            this._productype.Text = "Filtrar por tipo...";
            this._productype.SelectedIndexChanged += new System.EventHandler(this.ProductTypeSelected);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 423);
            this.Controls.Add(this._panel);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this._panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _addProductBtn;
        private System.Windows.Forms.ComboBox _productype;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}