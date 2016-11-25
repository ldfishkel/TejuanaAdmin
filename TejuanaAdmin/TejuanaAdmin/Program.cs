namespace TejuanaAdmin
{
    using Autofac;
    using IoC;
    using System;
    using System.Windows.Forms;

    static class Program
    {
        private static IContainer _container;

        [STAThread]
        static void Main()
        {
            InitializeDependencies();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_container.Resolve<MainForm>());
        }

        public static void InitializeDependencies()
        {
            var bootstrapper = new Bootstrapper();
            _container = bootstrapper.Build();
        }
    }
}
