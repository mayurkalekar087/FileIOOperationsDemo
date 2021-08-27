using System;
using System.IO;

namespace FileIOOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.FileExists();
            Program.ReadAllLine();
            Program.ReadAllText();
            //Calling Method
            //Stream Reader Writer Operations
            StreamReaderWriterOps streamReaderWriterOps = new StreamReaderWriterOps();
            streamReaderWriterOps.ReadFromStreamReader();
            streamReaderWriterOps.WriteUsingStreamWriter();
            
        }

        public static void FileExists()
        {
            string path = @"C:\Users\ASUS\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadLine();

        }
        public static void ReadAllLine()
        {
            string path = @"C:\Users\ASUS\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadKey();
        }
        public static void ReadAllText()
        {

            string path = @"C:\Users\ASUS\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }
    }

}


