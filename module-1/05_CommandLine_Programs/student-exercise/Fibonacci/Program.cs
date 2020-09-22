using System;

namespace Fibonacci
{
    class Program
    {



        static void Main(string[] args)
        {


            int numberOne = 0;
            int numberTwo = 1;
            int numberThree;


            Console.Write("Please enter the Fibonacci number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write(numberOne + " " + numberTwo + " ");
            for(int i = 1; i <  num; i++)
            {
                numberThree = numberOne + numberTwo;
                Console.Write(numberThree + " ");
                numberOne = numberTwo;
                numberTwo = numberThree;
            }
            Console.Read();

        }
    }
}









