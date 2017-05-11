using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "John";
            p.age = 42;

            // Serialize the Person object to a memory stream using DataContractJsonSerializer
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));

            // Use the WriteObject method to write JSON data to the stream
            ser.WriteObject(stream1, p);

            // Show the JSON output
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            Console.Write("JSON form of Person object: ");
            Console.WriteLine(sr.ReadToEnd());


            // Deserialize JSON-encoded data into new instance of Person by using ReadObject
            stream1.Position = 0;
            Person p2 = (Person)ser.ReadObject(stream1);

            // Show results
            Console.Write("Deserialized back, got name=");
            Console.Write(p2.name);
            Console.Write(", age=");
            Console.WriteLine(p2.age);
        }
    }
}
