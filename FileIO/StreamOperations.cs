using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class StreamOperations
    {
        public static void StreamReader()
        {
            string path = @"E:\io\FileIoDemo.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
                Console.WriteLine("----------------------------");
        }
        public static void StreamWriter()
        {
            string path = @"E:\io\FileIoDemo.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                Console.WriteLine("hello world");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.WriteLine("----------------------------");
        }
    }
}
