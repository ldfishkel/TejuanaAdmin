namespace TejuanaAdmin.Functionalities.Supply
{
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;

    public partial class SupplyForm : Form, ISupplyForm
    {
        public SupplyForm()
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
