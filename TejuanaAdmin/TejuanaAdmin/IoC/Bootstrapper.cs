namespace TejuanaAdmin.IoC
{
    using Autofac;

    public class Bootstrapper
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();

            //Modulo de Comunicación Servidor.
            builder.RegisterModule<TejuanaAdminModule>();

            builder.RegisterType<MainForm>().AsSelf();

            return builder.Build();
        }
    }
}
