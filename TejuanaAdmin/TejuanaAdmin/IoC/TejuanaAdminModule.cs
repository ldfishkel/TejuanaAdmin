namespace TejuanaAdmin.IoC
{
    using Autofac;
    using Contracts;
    using Daos;
    using Functionalities.Purchases;
    using Functionalities.Shipping;
    using Functionalities.Supply;
    using Functionalities.Withdraw;
    using Rest;
    using TejuanaAdmin.Functionalities;
    using View.Order;

    public class TejuanaAdminModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //Functions Froms
            builder.RegisterType<OrderForm>().As<IOrderForm>();
            builder.RegisterType<ProductForm>().As<IProductForm>();
            builder.RegisterType<PurchaseForm>().As<IPurchaseForm>();
            builder.RegisterType<ShippingForm>().As<IShippingorm>();
            builder.RegisterType<SupplyForm>().As<ISupplyForm>();
            builder.RegisterType<WithdrawForm>().As<IWithdrawForm>();

            //Daos
            builder.RegisterType<ProductDao>().AsSelf();
            builder.RegisterType<SupplyDao>().AsSelf();
            builder.RegisterType<OrderDao>().AsSelf();
            builder.RegisterType<ShippingDao>().AsSelf();

            //Rest
            builder.RegisterType<RequestHandler>().AsSelf();
        }
    }
}
