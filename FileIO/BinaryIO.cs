using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class BinaryIO
    {
        public void Serialize()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"E:\io\FileIoDemoNew.txt",FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
        }
    }
    [Serializable]
    public class Demo
    {
        public string name { get; set; } = "binary serialize";
        public string id { get; set; } = "1001";
    }
}
