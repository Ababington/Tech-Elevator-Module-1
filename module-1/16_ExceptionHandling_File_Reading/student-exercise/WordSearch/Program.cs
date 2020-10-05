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

            Console.WriteLine("What is the search word you are looking for?");
            string userInput = Console.ReadLine();
           
            Console.WriteLine("Should the search be case sensitive? (Y or N)");
            string caseSensitive = Console.ReadLine();

            bool fileExists = File.Exists(filePath);

            if (fileExists)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {

                        int number = 0;

                        while (!sr.EndOfStream)
                        {
                            number++;

                            string line = sr.ReadLine();
                            if (caseSensitive == "N")
                            {
                                if (line.Contains(userInput, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    Console.WriteLine(number + ")" + " " + line);
                                }
                            }
                            else if(line.Contains(userInput))
                            {
                                Console.WriteLine(number + ")" + " " + line);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, Try Again");
                    Console.WriteLine(e.Message);
                } 
            }
        }
    }
}
