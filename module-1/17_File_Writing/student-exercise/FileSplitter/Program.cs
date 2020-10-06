using System;
using System.Collections.Generic;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where is the input file (please include the path to the file)?");
            string filePath = Console.ReadLine();

            Console.WriteLine("How many lines of text (max) should there be in the split files?");
            string userInput = Console.ReadLine();
            int parsedUserInput = int.Parse(userInput);

            bool fileExists = File.Exists(filePath);

            if (fileExists)
            {
                string directory = Environment.CurrentDirectory;
                string fileName = filePath;
                string outputName = Path.GetFileNameWithoutExtension("input-1.txt");
                string fullPath = Path.Combine(directory, fileName);
                string outputFullPath = Path.Combine(directory, outputName);

                string fName = Path.GetFileNameWithoutExtension(fullPath);
                string fExtension = Path.GetExtension(fullPath);
                
                try
                {
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        using (StreamWriter sw = new StreamWriter(outputFullPath))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine().Substring(parsedUserInput);

                                sw.WriteLine(userInput);
                            }
                        }
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error, Try Again");
                }
            }
        }
    }
}