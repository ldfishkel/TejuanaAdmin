namespace TejuanaAdmin.Functionalities
{
    using Daos;
    using Rest;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;
    using View.Product;
    using ViewModel;

    public partial class ProductForm : Form, IProductForm
    {
        private readonly ProductDao _productDao;
        private readonly SupplyDao _supplyDao;

        public ProductForm(ProductDao productDao, SupplyDao supplyDao)
        {
            _productDao = productDao;
            _supplyDao = supplyDao;
        }

        public Panel Init(MainForm parent)
        {
            InitializeComponent();

            parent.FixBounds(_panel);

            LoadData();

            return _panel;
        }

        private void LoadData()
        {
            try
            {
                List<ProductTypeVM> productTypes = _productDao.GetProductTypes();

                _productype.Items.Clear();
                _productype.Items.AddRange(productTypes.ToArray());

                List<ProductVM> products = _productDao.GetProducts();

                LoadGrid(products);
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private void LoadGrid(List<ProductVM> products)
        {
            _products.Rows.Clear();

            foreach (ProductVM product in products)
                _products.Rows.Add(product,
                                    product.Type.Name,
                                    product.Name,
                                    Decimal.ToInt32(product.Price),
                                    product.Stock,
                                    "Editar");
        }

        private void AddColorToStock(int count)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle()
            {
                BackColor = Color.Red,
                ForeColor = Color.Black
            };

            for (int i = 0; i < count; i++)
            {
                var cell = _products.Rows[i].Cells[4];

                if ((int)cell.Value < 0)
                    cell.Style = style;
            }
        }

        private void ProductTypeSelected(object sender, EventArgs e)
        {
            try
            { 
                ProductTypeVM type = (ProductTypeVM)_productype.SelectedItem;

                List<ProductVM> products = _productDao.GetProducts(type);

                LoadGrid(products);
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ProductVM product = (ProductVM)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                EditProduct(product);
            }
        }

        private void AddProductClick(object sender, EventArgs e)
        {
            ProductDetailsForm newProductForm = new ProductDetailsForm(_productDao, _supplyDao);

            newProductForm.OnSaved(LoadData);

            newProductForm.Show();
        }

        private void EditProduct(ProductVM product)
        {
            ProductDetailsForm editProdictForm = new ProductDetailsForm(_productDao, _supplyDao, product);

            editProdictForm.OnSaved(LoadData);

            editProdictForm.Show();
        }
    }
}
