using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.BusinessLogic;
using Autofac;


namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<MyService.TheServiceClient>().As<MyService.ITheService>();
            builder.Register<Core>(b => new Core(b.Resolve<IComponentContext>(), b.Resolve<DemoApp.MyService.ITheService>()));
            builder.Register<BusinessLogic.VeryImportantBusinessLogic>(b => new VeryImportantBusinessLogic()).InstancePerLifetimeScope();

            IContainer Container = builder.Build();

            Console.WriteLine(Container.Resolve<Core>().Init());

            Console.WriteLine("\nHit enter to exit ...");
            Console.Read();
        }
    }
}
