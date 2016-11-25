namespace TejuanaAdmin.Functionalities.Stock
{
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;

    public partial class StockForm : Form, IStockForm
    {
        public StockForm()
        {
        }

        public Panel Init(MainForm parent)
        {
            InitializeComponent();

            parent.FixBounds(_panel);

            return _panel;
        }
    }
}
