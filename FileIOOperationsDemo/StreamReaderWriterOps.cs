using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOOperationsDemo
{
    public class StreamReaderWriterOps
    {
        public void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\ASUS\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World - .Net is Awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        public void ReadFromStreamReader()
        {
            string path = @"C:\Users\ASUS\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();

        }

    }
}

