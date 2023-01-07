using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileIO
{
    internal class BinaryDeserialization
    {

        public void DeSerialize()
        {
            FileStream fileStream = new FileStream(@"E:\io\FileIoDemo.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo Deserialize_sample = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Name:{Deserialize_sample.name}  id: {Deserialize_sample.id}");

        }
    }
}
