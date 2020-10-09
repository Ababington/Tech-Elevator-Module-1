using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string filePath = Console.ReadLine();
            // C:\Users\Student\workspace\augustbabington-c\module-1\16_ExceptionHandling_File_Reading\alices_adventures_in_wonderland.txt

            Console.WriteLine("What is the search word you are looking for?");
            string userInput = Console.ReadLine();

            Console.WriteLine("What should we replace that word with? ");
            string userOutput = Console.ReadLine();

            string outputFile = "word_replace.txt";
            bool fileExists = File.Exists(filePath);

            if (fileExists)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        using (StreamWriter sw = new StreamWriter(userOutput))
                        {
                            string outputFullPath = Path.Combine(filePath, outputFile);

                            while (!sr.EndOfStream)
                            {

                                string line = sr.ReadLine();


                                string fixedLine = line.Replace(userInput, userOutput);

                                sw.WriteLine(fixedLine);
                            }
                        }
                    }

                }
                catch (Exception e)
                {

                }


                //File.Copy(outputFullPath);

            }
        }
    }
}
