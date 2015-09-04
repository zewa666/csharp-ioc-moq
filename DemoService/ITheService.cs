using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoService
{
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
