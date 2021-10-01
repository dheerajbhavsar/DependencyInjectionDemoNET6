using Autofac;
using DemoLibrary;
using System.Reflection;

namespace ConsoleApp
{
    internal class ContainerConfig
    {
        public static IContainer Configure()
        {
            var container = new ContainerBuilder();

            container.RegisterType<Application>().As<IApplication>();
            container.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            container.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .AsImplementedInterfaces();

            return container.Build();
        }
    }
}
