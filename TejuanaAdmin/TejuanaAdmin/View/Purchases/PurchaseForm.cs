namespace TejuanaAdmin.Functionalities.Purchases
{
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;

    public partial class PurchaseForm : Form, IPurchaseForm
    {
        public PurchaseForm()
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
