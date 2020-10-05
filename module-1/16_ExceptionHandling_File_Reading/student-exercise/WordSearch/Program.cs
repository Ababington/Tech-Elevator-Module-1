using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string



            //2. Ask the user for the file path
            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string filePath = Console.ReadLine();
            // "C: \Users\Student\workspace\augustbabington - c\module - 1\16_ExceptionHandling_File_Reading\student - exercise\"
            Console.WriteLine("What is the search word you are looking for?");
            string userInput = Console.ReadLine();
            //alices_adventures_in_wonderland.txt


            bool fileExists = File.Exists(filePath);

            if (fileExists)
            {

                //3. Open the file
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                        if (!fileExists)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                File.Exists(filePath);
                            }
                                
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("alices_adventures_in_Wonderland.txt");
                //4. Loop through each line in the file

                //5. If the line contains the search string, print it out along with its line number
            }
        }
    }
}
