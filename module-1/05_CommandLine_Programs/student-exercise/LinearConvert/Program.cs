using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter length: ");
            string chooseLength = Console.ReadLine();
            double lengthNumber = double.Parse(chooseLength);

            Console.WriteLine("Is the measurement in (m)eter, or (f)eet? ");
            string lengthChoice = Console.ReadLine();



            switch (lengthChoice)
            {
                case "m":
                    Console.WriteLine(lengthNumber * 0.3048 + "f");
                    break;

                case "f":
                    Console.WriteLine(lengthNumber * 3.2808399 + "m");
                    break;
                default:
                    break;
            }

        }
    }
}
