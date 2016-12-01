namespace TejuanaAdmin.View.Product
{
    using System.Windows.Forms;

    public partial class ViewImageForm : Form
    {
        public ViewImageForm(string url)
        {
            InitializeComponent();
            _image.Load(url);
        }
    }
}
