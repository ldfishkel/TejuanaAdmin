namespace TejuanaAdmin.Functionalities.Shipping
{
    using Daos;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;
    using ViewModel.Shipping;

    public partial class ShippingForm : Form, IShippingorm
    {
        private readonly ShippingDao _shippingDao;

        public ShippingForm(ShippingDao shippingDao)
        {
            _shippingDao = shippingDao;
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
            List<ShippingVM> shippings = _shippingDao.GetShippingList();

            LoadGrid(shippings);
        }

        private void LoadGrid(List<ShippingVM> shippings)
        {
            _shippings.Rows.Clear();

            foreach (ShippingVM shipping in shippings)
                _shippings.Rows.Add(shipping, shipping.ClientId, shipping.Address, shipping.Zipcode, shipping.Status, "Detalle", "Enviado");
        }
    }
}
