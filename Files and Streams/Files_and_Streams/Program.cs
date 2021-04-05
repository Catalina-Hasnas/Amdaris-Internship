using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Files_and_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\CutepPie\Desktop\Amdaris Internship\Files and Streams\Files_and_Streams";
            string fileName = "Test.txt";

            var filePath = Path.Combine(rootPath, fileName);

            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath));
            }
            else
            {
                Console.WriteLine($"File {fileName} already exists.");
                return;
            }

            List<string> lines = File.ReadAllLines(filePath).ToList();
         
            lines.Add("first line");
            lines.Add("second line");
            lines.Add("third line");

            File.WriteAllLines(filePath, lines);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
