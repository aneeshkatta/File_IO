using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Operation
    {
        public static void FileExists()
        {
            string path = @"E:\io\FileIoDemo.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File not Exists");
            }
            Console.WriteLine("----------------------------");
        }
        public static void ReadLines()
        {
            string path = @"E:\io\FileIoDemo.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine("----------------------------");
        }
        public static void ReadAlltext()
        {
            string path = @"E:\io\FileIoDemo.txt";
            String lines;//remove array
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.WriteLine("----------------------------");
        }
        public static void FileCopy()
        {
            string path = @"E:\io\FileIoDemo.txt";
            string pathcopy = @"E:\io\FileIoDemoNew.txt";
            File.Copy(path, pathcopy);
            Console.WriteLine("----------------------------");
        }
        public static void FileDelete()
        {
            string path = @"E:\io\xyz.txt";
            File.Delete(path);
            Console.WriteLine("----------------------------");
        }
    }
}
