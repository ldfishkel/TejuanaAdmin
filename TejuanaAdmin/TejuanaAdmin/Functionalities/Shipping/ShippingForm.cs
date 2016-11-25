namespace TejuanaAdmin.Functionalities.Shipping
{
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;

    public partial class ShippingForm : Form, IShippingorm
    {
        public ShippingForm()
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
