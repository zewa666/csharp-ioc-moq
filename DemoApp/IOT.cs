using Autofac;
using DemoApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public static class IOT
    {
        public static IContainer Container { get; set; }

        public static IContainer Build() {
            var builder = new ContainerBuilder();

            builder.RegisterType<MyService.TheServiceClient>().As<MyService.ITheService>();
            builder.Register<BusinessLogic.VeryImportantBusinessLogic>(b => new VeryImportantBusinessLogic()).InstancePerLifetimeScope();

            Container = builder.Build();
            return Container;
        }
    }
}
