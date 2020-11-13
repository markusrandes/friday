using System;
using System.IO;

namespace friday
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            string directoriesTxt = @"C:\Users\opilane\Friday\sampleDirectories.txt";
            string filesTxt = @"C:\Users\opilane\Friday\sampleFiles.txt";

            string[] includeNestedDirecotries = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            string[] allFiles = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);

            File.WriteAllLines(directoriesTxt, includeNestedDirecotries);
            File.WriteAllLines(filesTxt, allFiles);
            Console.WriteLine("Complete");
        }
    }
}