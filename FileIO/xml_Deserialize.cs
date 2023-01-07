using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO
{
    internal class xml_Deserialize
    { 
        public static void Xmldeserialize(string pathxml)
        {
            XmlSerializer objdeserializer = new XmlSerializer(typeof(List<Person>));
            StreamReader objreader = new StreamReader(pathxml);
            List<Person> personlistobj =(List<Person>)objdeserializer.Deserialize(objreader);
            foreach(Person persondetail in personlistobj)
            {
                Console.WriteLine(persondetail);
            }
        }
    }
}
