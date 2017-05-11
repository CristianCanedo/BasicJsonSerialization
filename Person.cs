using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Serialize
{
    // Defining data contract for Person using DataContract attribute
    [DataContract]
    internal class Person
    {
        // Defining data contract for Person members using DataMember attribute
        [DataMember]
        internal string name;

        [DataMember]
        internal int age;
    }
}
