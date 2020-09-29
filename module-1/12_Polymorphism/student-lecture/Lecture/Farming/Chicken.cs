using System;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, ISellable
    {
        public Chicken() : base("Chicken", "cluck")
        {
        }

        public decimal GetSalesPrice()
        {
            return 12M;
        }

        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }
    }
}
