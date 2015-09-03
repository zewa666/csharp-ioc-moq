using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.BusinessLogic
{
    public class VeryImportantBusinessLogic
    {
        public dynamic GetVIP()
        {
            return new {
                firstName = "Vildan",
                lastName = "Softic"
            };
        }
    }
}
