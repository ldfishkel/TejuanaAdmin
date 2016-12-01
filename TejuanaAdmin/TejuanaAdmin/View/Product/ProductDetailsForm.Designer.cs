namespace TejuanaAdmin.View.Product
{
    partial class ProductDetailsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._supplies = new System.Windows.Forms.DataGridView();
            this.Supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Needed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._imageURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.TextBox();
            this._price = new System.Windows.Forms.NumericUpDown();
            this._productType = new System.Windows.Forms.ComboBox();
            this._stock = new System.Windows.Forms.NumericUpDown();
            this._size = new System.Windows.Forms.ComboBox();
            this._avgProductionTime = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._supplies)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._avgProductionTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 318);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(11, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 42);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(544, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._supplies);
            this.groupBox2.Location = new System.Drawing.Point(311, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 266);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insumos";
            // 
            // _supplies
            // 
            this._supplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supply,
            this.amount,
            this.Needed});
            this._supplies.Location = new System.Drawing.Point(13, 20);
            this._supplies.Name = "_supplies";
            this._supplies.RowHeadersVisible = false;
            this._supplies.Size = new System.Drawing.Size(230, 233);
            this._supplies.TabIndex = 0;
            // 
            // Supply
            // 
            this.Supply.HeaderText = "Insumo";
            this.Supply.Name = "Supply";
            this.Supply.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.FillWeight = 50F;
            this.amount.HeaderText = "Cant.";
            this.amount.Name = "amount";
            this.amount.Width = 50;
            // 
            // Needed
            // 
            this.Needed.FillWeight = 50F;
            this.Needed.HeaderText = "Si/No";
            this.Needed.Name = "Needed";
            this.Needed.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._imageURL);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._name);
            this.groupBox1.Controls.Add(this._price);
            this.groupBox1.Controls.Add(this._productType);
            this.groupBox1.Controls.Add(this._stock);
            this.groupBox1.Controls.Add(this._size);
            this.groupBox1.Controls.Add(this._avgProductionTime);
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 266);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Ver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ViewImageClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Imagen";
            // 
            // _imageURL
            // 
            this._imageURL.Location = new System.Drawing.Point(71, 52);
            this._imageURL.Name = "_imageURL";
            this._imageURL.Size = new System.Drawing.Size(133, 20);
            this._imageURL.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Talle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(71, 19);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(214, 20);
            this._name.TabIndex = 1;
            // 
            // _price
            // 
            this._price.Location = new System.Drawing.Point(71, 233);
            this._price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(120, 20);
            this._price.TabIndex = 6;
            // 
            // _productType
            // 
            this._productType.FormattingEnabled = true;
            this._productType.Location = new System.Drawing.Point(72, 86);
            this._productType.Name = "_productType";
            this._productType.Size = new System.Drawing.Size(132, 21);
            this._productType.TabIndex = 2;
            // 
            // _stock
            // 
            this._stock.Location = new System.Drawing.Point(71, 196);
            this._stock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._stock.Name = "_stock";
            this._stock.Size = new System.Drawing.Size(120, 20);
            this._stock.TabIndex = 5;
            // 
            // _size
            // 
            this._size.FormattingEnabled = true;
            this._size.Location = new System.Drawing.Point(71, 122);
            this._size.Name = "_size";
            this._size.Size = new System.Drawing.Size(133, 21);
            this._size.TabIndex = 3;
            // 
            // _avgProductionTime
            // 
            this._avgProductionTime.Location = new System.Drawing.Point(71, 160);
            this._avgProductionTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._avgProductionTime.Name = "_avgProductionTime";
            this._avgProductionTime.Size = new System.Drawing.Size(120, 20);
            this._avgProductionTime.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewProductTypeClick);
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 341);
            this.Controls.Add(this.panel1);
            this.Name = "ProductDetailsForm";
            this.Text = "ProductDetailsForm";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._supplies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._avgProductionTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox _size;
        private System.Windows.Forms.ComboBox _productType;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.NumericUpDown _stock;
        private System.Windows.Forms.NumericUpDown _avgProductionTime;
        private System.Windows.Forms.NumericUpDown _price;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _supplies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supply;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Needed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _imageURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}