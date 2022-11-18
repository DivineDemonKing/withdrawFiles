using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace withdrawFiles
{
    class Program
    {
        static void withdraw(string path)
        {
            string[] arrayFile = Directory.GetFiles(path);
            string[] arrayDirectory = Directory.GetDirectories(path);
            FileInfo temp;

            if (arrayDirectory.Length != 0)
            {
                foreach (string directory in arrayDirectory)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine($"Директория {directory}");
                    withdraw(directory);
                }
            }
            else
            {
                foreach (string file in arrayFile)
                {
                    temp = new FileInfo(file);
                    Console.WriteLine(temp.Name);
                }
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Program Files (x86)\Steam\steamapps\common\DARK SOULS III";
            withdraw(path);
        }
    }
}
