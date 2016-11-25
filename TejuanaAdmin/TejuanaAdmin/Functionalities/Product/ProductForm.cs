namespace TejuanaAdmin.Functionalities
{
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;

    public partial class ProductForm : Form, IProductForm
    {
        public ProductForm()
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
