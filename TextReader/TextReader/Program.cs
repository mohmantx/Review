using System;
using System.IO;

namespace TextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\mohma\Downloads\Pride and Prejudice by Jane Austen.txt";

            string readfile = File.ReadAllText(filePath);
            
            //Console.WriteLine(readfile);

            var lines = File.ReadAllLines(filePath);

            //output 5 lines at a time
            //for (int i = 0; i< lines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(lines[i]);
            //}

            for (int i = 0; i < lines.Length; i++)
            {
                string currentline = lines[i];
                if (currentline.Contains("Chapter"))
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
