using System;

namespace SI4
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodProduct p = new FoodProduct(2352662, "Cheese", "Milfina", 126, new DateTime(2019, 3, 2));
            System.Console.WriteLine(p);
            System.Console.WriteLine(p.IsStillConsumable());
        }
    }
}
