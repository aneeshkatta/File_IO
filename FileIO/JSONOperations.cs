using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileIO
{
    class JSONOperations
    {
        public static string pathjson = @"E:\JsonDataSerialize.json";
        public static void JsonSerialization( List<Person> list)
        {
            //List<Person> list = new List<Person>()
            //        {
            //            new Person(){PersonId = 1, Name = "ravi", PhoneNumber = 4532233, Address = "hyd" },
            //            new Person(){PersonId = 2, Name = "rohan", PhoneNumber = 452233, Address = "hyd" },
            //            new Person(){PersonId = 3, Name = "kranthi", PhoneNumber = 289233, Address = "bnglr" },
            //            new Person(){PersonId = 4, Name = "Kumar", PhoneNumber = 123456, Address = "mumbai" }
            //        };
            string jsonData = JsonConvert.SerializeObject(list);
            File.WriteAllText(pathjson, jsonData);
        }
        public static List<Person> JsonDeserialization()
        {
            string result = File.ReadAllText(pathjson);
            List<Person> listOfPerson = JsonConvert.DeserializeObject<List<Person>>(result);
            foreach (Person person in listOfPerson)
            {
                Console.WriteLine(person);
            }
            return listOfPerson;
        }
    }
    public class Person
    {
        public int PersonId { get; set; }
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public override string ToString()
        {
            return $"ID:{PersonId}  Phone:{PhoneNumber}  Name:{Name}  Address:{Address}  Date:{StartDate}";
        }
    }
}

