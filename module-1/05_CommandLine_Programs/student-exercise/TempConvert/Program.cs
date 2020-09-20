using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter temperature: ");
            string chooseTemp = Console.ReadLine();
            double tempNumber = double.Parse(chooseTemp);

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit?: ");
            string tempChoice = Console.ReadLine();

          

            switch (tempChoice)
            {
                case "C":
                    Console.WriteLine((tempNumber * 1.8) + 32 + "F " + "is " + tempNumber + "C");
                    break;

                case "F":
                    Console.WriteLine(tempNumber + "F " + "is " + (tempNumber - 32) / 1.8 + "C");
                    break;
                default:
                    break;
            }
            
        }
    }
}




