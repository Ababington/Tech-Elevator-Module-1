using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Please enter temperature: ");
            string chooseTemp = Console.ReadLine();
            double tempNumber = double.Parse(chooseTemp);

            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit?: ");
            string tempChoice = Console.ReadLine();



            switch (tempChoice)
            {
                case "C":
                    Console.WriteLine(tempNumber + "C " + "is " + (tempNumber * 1.8) + 32 + "F");
                    break;

                case "F":
                    Console.WriteLine(tempNumber + "F " + "is " + (tempNumber - 32) / 1.8 + "C");
                    break;
               
                default:
                    Console.WriteLine("Please enter valid Dollar amount");
                    break;
            }
            
        }
    }
}




