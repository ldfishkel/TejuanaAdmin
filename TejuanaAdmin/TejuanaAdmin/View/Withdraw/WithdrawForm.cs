namespace TejuanaAdmin.Functionalities.Withdraw
{
    using System.Windows.Forms;
    using TejuanaAdmin.Contracts;

    public partial class WithdrawForm : Form, IWithdrawForm
    {
        public WithdrawForm()
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
