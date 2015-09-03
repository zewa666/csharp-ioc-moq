using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "TheService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class TheService : ITheService
    {
        public string RegisterPerson(Person p)
        {
            return string.Format("Successfully registered {0} {1}", p.FirstName, p.LastName);
        }
    }
}
