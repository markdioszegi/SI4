using System;
using System.Collections.Generic;
using SI4.API;

namespace SI4
{
    public class CmdProgram
    {
        List<Product> cart;
        List<float> prices;
        public CmdProgram(string[] args)
        {
            cart = new List<Product>();
            prices = new List<float>();
        }

        public void Run()
        {
            DateTime time = DateTime.Now;

            Console.Clear();
            System.Console.WriteLine("There are no plaza created yet! Press");
            System.Console.WriteLine("1) to create a new plaza.");
            System.Console.WriteLine("2) to exit.");
            Plaza p = new Plaza("plaza");
            Shop hm = new Shop("H&M", "joska");
            p.Close();
            p.Open();
            System.Console.WriteLine(p.IsOpen());
            p.AddShop(hm);
            //p.RemoveShop(hm);

            foreach (IShop shop in p.GetShops())
            {
                System.Console.WriteLine("Shop: " + shop.GetName());
            }

            DateTime lastTime = DateTime.Now;
            System.Console.WriteLine($"It took {(lastTime - time).Milliseconds} milliseconds!");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        System.Console.Write("Enter a name: ");
                        Plaza plaza = new Plaza(Console.ReadLine());
                        ShowPlazaMenu(plaza);
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        throw new NotSupportedException("No such menu item!");
                }
            }
        }

        void ShowPlazaMenu(Plaza plaza)
        {
            bool returnPlaza = false;
            while (!returnPlaza)
            {
                System.Console.WriteLine($"Hi! This is the {plaza.Name}, welcome! Press");
                System.Console.WriteLine("1) to list available products.");
                System.Console.WriteLine("2) to find products by name.");
                System.Console.WriteLine("4) to display the shop's owner.");
                System.Console.WriteLine("5) to open the shop.");
                System.Console.WriteLine("6) to close the shop.");
                System.Console.WriteLine("7) to add new product to the shop.");
                System.Console.WriteLine("8) to add existing products to the shop.");
                System.Console.WriteLine("9) to buy a product by barcode.");
                System.Console.WriteLine("10) check price by barcode.");
                System.Console.WriteLine("N) go back to plaza.");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        break;
                    case "n":
                        returnPlaza = true;
                        break;
                    default:
                        throw new NotSupportedException("No such menu item!");
                }
            }
        }
    }
}