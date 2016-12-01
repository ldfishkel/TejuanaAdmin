namespace TejuanaAdmin.View.Product
{
    using Daos;
    using Rest;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using ViewModel;
    using ViewModel.Product;

    public partial class NewProductTypeForm : Form
    {
        private ProductDao _productDao;
        private Action _onSaved;

        public NewProductTypeForm(ProductDao productDao)
        {
            InitializeComponent();

            _productDao = productDao;

            LoadData();
        }

        internal void OnSaved(Action loadData)
        {
            _onSaved = loadData;
        }

        private void LoadData()
        {
            try
            {
                _tag.Clear();
                _tags.Rows.Clear();

                foreach (TagVM tag in _productDao.GetTags())
                    _tags.Rows.Add(tag, false);
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private void AddTagClick(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateTag())
                    return;
                
                _productDao.AddTag(new TagVM() { Name = _tag.Text });

                LoadData();
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private bool ValidateTag()
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrWhiteSpace(_tag.Text))
                sb.AppendLine("Ingresa el nombre del tag");
            else if (!Regex.IsMatch(_tag.Text.Trim(), "([a-z][A-Z][1-9]){3,10}"))
                sb.AppendLine("Nombre incorrecto (entre 3 y 30 letras y numeros unicamente)");

            if (sb.Length == 0)
                return true;

            MessageBox.Show(sb.ToString(), "Alto ahi loca!");
            return false;
        }

        private void AddProductTypeClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                var productType = BuildProductType();

                _productDao.AddProductType(productType);

                Close();

                _onSaved.Invoke();
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error en el servidor");
            }
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrWhiteSpace(_name.Text))
                sb.AppendLine("Ingresa el nombre del tipo de producto");
            if (GetSelectedTags().Count == 0)
                sb.AppendLine("Ponele tags");

            if (sb.Length == 0)
                return true;

            MessageBox.Show(sb.ToString(), "Alto ahi loca!");
            return false;
        }

        private ProductTypeVM BuildProductType()
        {
            ProductTypeVM productType = new ProductTypeVM();

            productType.Name = _name.Text.Trim();
            productType.Tags = GetSelectedTags();

            return productType;               
        }

        private HashSet<TagVM> GetSelectedTags()
        {
            HashSet<TagVM> tags = new HashSet<TagVM>();

            for (int i = 0; i < _tags.RowCount; i++)
                if (_tags.Rows[i].Cells[1].Value != null && (bool)_tags.Rows[i].Cells[1].Value == true)
                    tags.Add((TagVM)_tags.Rows[i].Cells[0].Value);

            return tags;
        }
    }
}
