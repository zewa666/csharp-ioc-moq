using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace DemoService
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:9001/TheService");

            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(TheService), baseAddress))
            {
                host.AddServiceEndpoint(typeof(ITheService), new WSHttpBinding(), "");
                ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                serviceBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceBehavior);

                host.Open();

                Console.WriteLine("Hit enter to exit ...");
                Console.Read();

                host.Close();
            }
        }
    }
}
