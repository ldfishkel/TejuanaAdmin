namespace TejuanaAdmin.View.Product
{
    using Daos;
    using Rest;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using TejuanaAdmin.ViewModel;

    public partial class ProductDetailsForm : Form
    {
        private ProductVM _product;
        private readonly SupplyDao _supplyDao;
        private readonly ProductDao _productDao;
        private Action _onSaved;

        public ProductDetailsForm(ProductDao productDao, SupplyDao supplyDao)
        {
            InitializeComponent();

            _supplyDao = supplyDao;
            _productDao = productDao;

            InitializeData();
        }

        public ProductDetailsForm(ProductDao productDao, SupplyDao supplyDao, ProductVM product)
        {
            InitializeComponent();

            _supplyDao = supplyDao;
            _productDao = productDao;

            _product = product;

            LoadData();
        }

        private void InitializeData()
        {
            InitializeProductTypes();

            _size.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL" });

            List<ProductSupplyVM> supplies = _supplyDao.GetProductSupplies();

            foreach (ProductSupplyVM supply in supplies)
                _supplies.Rows.Add(supply, "", false);
        }

        private void InitializeProductTypes()
        {
            try
            {
                _productType.Items.Clear();
                _productType.Items.AddRange(_productDao.GetProductTypes().ToArray());
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private void LoadData()
        {
            try
            {
                List<ProductSupplyVM> supplies = _supplyDao.GetProductSupplies().Where(x => !_product.Supplies.Any(y => y.Id == x.Id)).ToList();

                foreach (ProductSupplyVM supply in _product.Supplies)
                    _supplies.Rows.Add(supply, supply.Amount, true);

                foreach (ProductSupplyVM supply in supplies)
                    _supplies.Rows.Add(supply, "", false);

                _productType.Items.AddRange(_productDao.GetProductTypes().ToArray());

                _size.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL" });

                _name.Text = _product.Name;
                _imageURL.Text = _product.ImageURL;
                _size.SelectedItem = _product.Size;
                _avgProductionTime.Value = _product.AvgProductionTime;
                _price.Value = _product.Price;
                _stock.Value = _product.Stock;
                _productType.SelectedItem = _product.Type;
                _productType.Text = _product.Type.Name;
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            try
            { 
                if (!ValidateFields())
                    return;

                bool edit = _product != null && _product.Id != 0;

                var product = BuildProduct();

                if (edit)
                {
                    product.Id = _product.Id;
                    _productDao.UpdateProduct(product);
                }
                else
                    _productDao.AddProduct(product);

                _onSaved.Invoke();
                Close();
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (_productType.SelectedItem == null)
                sb.AppendLine("Tenes que seleccionar tipo de producto");
            if (_size.SelectedItem == null)
                sb.AppendLine("Tenes que seleccionar Talle");
            if (String.IsNullOrWhiteSpace(_imageURL.Text))
                sb.AppendLine("Tenes que ingresar la url de la imagen");
            if (String.IsNullOrWhiteSpace(_name.Text))
                sb.AppendLine("Tenes que ingresar el nombre");
            if (_avgProductionTime.Value == 0)
                sb.AppendLine("Tenes que indicar el tiempo de produccion promedio");
            if (_price.Value == 0)
                sb.AppendLine("Tenes que indicar el precio");
            if (!ValidateSelectedSupplies())
                sb.AppendLine("Datos incorrectos en tabla de insumos");

            if (sb.Length == 0)
                return true;

            MessageBox.Show(sb.ToString());

            return false;
        }

        internal void OnSaved(Action loadData)
        {
            _onSaved = loadData;
        }

        private bool ValidateSelectedSupplies()
        {
            HashSet<ProductSupplyVM> supplies = GetSelectedSupplies();

            foreach (ProductSupplyVM supply in supplies)
                if (supply.Amount <= 0 || supply.Id == 0 || String.IsNullOrWhiteSpace(supply.Name))
                    return false;

            return true;
        }

        private ProductVM BuildProduct()
        {
            var product = new ProductVM();

            product.Name = _name.Text;
            product.ImageURL = _imageURL.Text;
            product.Price = _price.Value;
            product.Type = new ProductTypeVM();
            product.Type.Id = ((ProductTypeVM)_productType.SelectedItem).Id;
            product.AvgProductionTime = (int)_avgProductionTime.Value;
            product.Size = (string)_size.SelectedItem;
            product.Supplies = GetSelectedSupplies();
            product.Stock = (int)_stock.Value;

            return product;
        }

        private HashSet<ProductSupplyVM> GetSelectedSupplies()
        {
            HashSet<ProductSupplyVM> supplies = new HashSet<ProductSupplyVM>();

            for (int i = 0; i < _supplies.RowCount; i++)
                if (_supplies.Rows[i].Cells[2].Value != null && (bool)_supplies.Rows[i].Cells[2].Value == true)
                {
                    ProductSupplyVM supply = (ProductSupplyVM)_supplies.Rows[i].Cells[0].Value;
                    var value = _supplies.Rows[i].Cells[1].Value;
                    int n;
                    if (value == null || (value is string && !int.TryParse((string)value, out n)))
                        supply.Amount = -1;
                    else if (value is string)
                        supply.Amount = Int32.Parse((string)value);
                    else
                        supply.Amount = (int)value;

                    supplies.Add(supply);
                }

            return supplies;
        }

        private void ViewImageClick(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(_imageURL.Text))
                return;

            ViewImageForm viewImageForm = new ViewImageForm(_imageURL.Text);

            viewImageForm.Show();
        }

        private void NewProductTypeClick(object sender, EventArgs e)
        {
            NewProductTypeForm newProductTypeForm = new NewProductTypeForm(_productDao);

            newProductTypeForm.OnSaved(InitializeProductTypes);

            newProductTypeForm.Show();
        }
    }
}
