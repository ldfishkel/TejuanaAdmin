namespace TejuanaAdmin.Functionalities.Supply
{
    using Daos;
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;
    using ViewModel.Supply;
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public partial class SupplyForm : Form, ISupplyForm
    {
        private readonly SupplyDao _supplyDao;

        public SupplyForm(SupplyDao supplyDao)
        {
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
            _supplies.Rows.Clear();

            List<SupplyVM> supplies = _supplyDao.GetSupplies();

            foreach (SupplyVM supply in supplies)
                _supplies.Rows.Add(supply, supply.Name, supply.Stock, supply.RealStock, Utils.FormatDate(supply.lastTimeSupplied), "Edit");

            AddColorToStock(supplies.Count);
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
                var cell = _supplies.Rows[i].Cells[3];

                if ((int)cell.Value < 0)
                    cell.Style = style;
            }
        }
    }
}
