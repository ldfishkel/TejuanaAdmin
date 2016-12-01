namespace TejuanaAdmin.View.Order
{
    using Daos;
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;
    using ViewModel.Order;

    public partial class OrderForm : Form, IOrderForm
    {
        private readonly OrderDao _orderDao;

        public OrderForm(OrderDao orderDao)
        {
            _orderDao = orderDao;
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
            _orders.Rows.Clear();

            foreach (OrderVM order in _orderDao.GetOrderList())
                _orders.Rows.Add(order, order.ClientId, 
                    order.ProductName, 
                    order.ProductAmount, 
                    Utils.FormatDate(order.EstimatedDate), 
                    "Terminado");
        }
    }
}
