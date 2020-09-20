using System;

namespace Fibonacci
{
    class Program
    {



        static void Main(string[] args)
        {



            Console.WriteLine("Please enter degrees: ");
            string chooseTemp = Console.ReadLine();
            double tempNumber = double.Parse(chooseTemp);

            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit?: ");
            string tempChoice = Console.ReadLine();

            Console.WriteLine("Converted Temperature: ");
            string result = Console.ReadLine();
            double resultTemp = double.Parse(result);

            if (tempChoice == "C")
            {
                resultTemp = (tempNumber * 1.8) + 32;
            }

            if (tempChoice == "F")
            {
                resultTemp = ((tempNumber - 32) / 1.8);
            }
            Console.WriteLine(resultTemp);
        }
    }
}








