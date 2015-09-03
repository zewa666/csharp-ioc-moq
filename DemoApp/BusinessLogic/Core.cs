using Autofac;
using DemoApp.MyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.BusinessLogic
{
    public class Core
    {
        IComponentContext context;

        public ITheService Service { get; set; }
        public Core(IComponentContext context, ITheService srv)
        {
            this.Service = srv;
            this.context = context;
        }

        public string Init()
        {
            var VIP = context.Resolve<VeryImportantBusinessLogic>().GetVIP();

            return this.Service.RegisterPerson(this.GeneratePerson(VIP.firstName, VIP.lastName));
        }

        public Person GeneratePerson(string firstName, string lastName)
        {
            return new Person()
            {
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}
