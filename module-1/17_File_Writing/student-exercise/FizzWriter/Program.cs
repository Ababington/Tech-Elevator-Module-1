using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, fileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))

                    for (int i = 0; i <= 300; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if (i % 5 == 0 || i.ToString().Contains("5"))
                        {
                            sw.WriteLine("Buzz");
                        }
                        else if (i % 3 == 0 || i.ToString().Contains("3"))
                        {
                            sw.WriteLine("Fizz");
                        }
                        else
                        {
                            sw.WriteLine(i);
                        }
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("Try again");
            }
        }
        
    }
}

