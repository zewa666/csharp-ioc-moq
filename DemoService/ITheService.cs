using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "ITheService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface ITheService
    {
        [OperationContract]
        string RegisterPerson(Person p);
    }

    [DataContract]
    public class Person {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
