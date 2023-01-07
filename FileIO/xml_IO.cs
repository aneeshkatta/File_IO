using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO
{
    public class xml_IO
    {
        public static string pathxml=@"E:\JsonDataSerialize.xml";
        public static void Xmlserialize(List<Person> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            StreamWriter sw = new StreamWriter(pathxml);
            xmlSerializer.Serialize(sw, list);
        }

    }
}
