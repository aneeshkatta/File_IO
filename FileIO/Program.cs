using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Program
    {
        public static string pathxml = @"E:\JsonDataSerialize.xml";
        public static void Main(string[] args)
        {
            List<Person> list = new List<Person>()
                    {
                        new Person(){PersonId = 1, Name = "ravi", PhoneNumber = 4532233, Address = "hyd" },
                        new Person(){PersonId = 2, Name = "rohan", PhoneNumber = 452233, Address = "hyd" },
                        new Person(){PersonId = 3, Name = "kranthi", PhoneNumber = 289233, Address = "bnglr" },
                        new Person(){PersonId = 4, Name = "Kumar", PhoneNumber = 123456, Address = "mumbai" }
                    };



            Operation.FileExists();
            Operation.ReadLines();
            Operation.ReadAlltext();
            Operation.FileCopy();
            Operation.FileDelete();

            StreamOperations.StreamReader();
            StreamOperations.StreamWriter();

            BinaryIO binaryio = new BinaryIO();
            binaryio.Serialize();
            BinaryDeserialization Bin_deserialize = new BinaryDeserialization();
            Bin_deserialize.DeSerialize();

            JSONOperations.JsonSerialization(list);
            JSONOperations.JsonDeserialization();

            xml_IO.Xmlserialize(list);
            xml_Deserialize.Xmldeserialize(pathxml);

        }
    }
}
