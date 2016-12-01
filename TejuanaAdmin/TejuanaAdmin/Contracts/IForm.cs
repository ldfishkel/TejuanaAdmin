namespace TejuanaAdmin.Contracts
{
    using System.Windows.Forms;

    public interface IForm
    {
        Panel Init(MainForm parent);
    }

    public interface IProductForm : IForm {}
    public interface IPurchaseForm : IForm {}
    public interface IShippingorm : IForm {}
    public interface ISupplyForm : IForm {}
    public interface IWithdrawForm : IForm {}
    public interface IOrderForm : IForm {}
}
