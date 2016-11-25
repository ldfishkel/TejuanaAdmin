namespace TejuanaAdmin.IoC
{
    using Autofac;
    using Contracts;
    using Functionalities.Purchases;
    using Functionalities.Shipping;
    using Functionalities.Stock;
    using Functionalities.Supply;
    using Functionalities.Withdraw;
    using TejuanaAdmin.Functionalities;

    public class TejuanaAdminModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //Functions Froms
            builder.RegisterType<ProductForm>().As<IProductForm>();
            builder.RegisterType<PurchaseForm>().As<IPurchaseForm>();
            builder.RegisterType<ShippingForm>().As<IShippingorm>();
            builder.RegisterType<StockForm>().As<IStockForm>();
            builder.RegisterType<SupplyForm>().As<ISupplyForm>();
            builder.RegisterType<WithdrawForm>().As<IWithdrawForm>();
        }
    }
}
