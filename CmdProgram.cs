using System;
using System.Collections.Generic;
using System.Linq;
using SI4.API;

namespace SI4
{
    public class CmdProgram
    {
        List<Product> cart;
        List<float> prices;
        List<Plaza> Plazas;
        public CmdProgram(string[] args)
        {
            Plazas = new List<Plaza>();
            cart = new List<Product>();
            prices = new List<float>();
        }

        public void Run()
        {
            DateTime time = DateTime.Now;

            while (true)
            {
                Console.Clear();
                if (Plazas.Count < 1)
                {
                    System.Console.WriteLine("There are no plaza created yet! Press");
                    System.Console.WriteLine("1) to create a new plaza.");
                    System.Console.WriteLine("2) to exit.");
                }
                else
                {
                    System.Console.WriteLine("Press");
                    System.Console.WriteLine("1) to create a new plaza.");
                    int i = 2;
                    foreach (var plaza in Plazas)
                    {
                        System.Console.WriteLine($"{i}) to enter {plaza.Name}.");
                        ++i;
                    }
                    System.Console.WriteLine("N) to exit.");
                }

                string input = Console.ReadLine();

                if (input == "1")
                {
                    System.Console.Write("Enter a name: ");
                    Plaza plaza = new Plaza(Console.ReadLine());
                    Plazas.Add(plaza);
                }
                else if (input == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    int _input = Convert.ToInt32(input);
                    Plaza plaza = null;

                    try
                    {
                        plaza = Plazas[_input - 2];
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Plaza not found!");
                    }

                    if (plaza != null)
                    {
                        ShowPlazaMenu(plaza);
                    }
                    else
                    {
                        throw new NotSupportedException("No such menu item!");
                    }
                }
            }
        }

        void ShowPlazaMenu(Plaza plaza)
        {
            bool leavePlaza = false;
            while (!leavePlaza)
            {
                Console.Clear();
                System.Console.WriteLine($"Welcome to the {plaza.Name} plaza! Press");
                System.Console.WriteLine("1) to list all shops.");
                System.Console.WriteLine("2) to add a new shop.");
                System.Console.WriteLine("3) to remove an existing shop.");
                System.Console.WriteLine("4) to enter a shop by name.");
                System.Console.WriteLine("5) to open the plaza.");
                System.Console.WriteLine("6) to close the plaza.");
                System.Console.WriteLine("7) to check if the plaza is open or not.");
                System.Console.WriteLine("N) leave plaza.");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        ListShops(plaza);
                        break;
                    case "2":
                        AddShop(plaza);
                        break;
                    case "3":
                        RemoveShop(plaza);
                        break;
                    case "4":
                        EnterShop(plaza);
                        break;
                    case "5":
                        plaza.Open();
                        System.Console.WriteLine("Plaza opened!");
                        Console.ReadKey();
                        break;
                    case "6":
                        plaza.Close();
                        System.Console.WriteLine("Plaza closed!");
                        Console.ReadKey();
                        break;
                    case "7":
                        if (plaza.IsOpen())
                        {
                            System.Console.WriteLine("The plaza is open.");
                        }
                        else
                        {
                            System.Console.WriteLine("The plaza is closed, get back tomorrow!");
                        }
                        Console.ReadKey();
                        break;
                    case "n":
                        leavePlaza = true;
                        break;
                    default:
                        throw new NotSupportedException("No such menu item!");
                }
            }
        }
        private void ListShops(Plaza plaza)
        {
            foreach (Shop shop in plaza.GetShops())
            {
                System.Console.WriteLine(shop.ToString());
            }
            Console.ReadKey();
        }
        private void AddShop(Plaza plaza)
        {
            System.Console.WriteLine("Shop name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Owner name: ");
            string owner = Console.ReadLine();
            plaza.AddShop(new Shop(name, owner));
            System.Console.WriteLine($"Shop {name} added!");
            Console.ReadKey();
        }

        private void RemoveShop(Plaza plaza)
        {
            System.Console.WriteLine("Enter the shop name: ");
            plaza.RemoveShop(plaza.FindShopByName(Console.ReadLine()));
            System.Console.WriteLine("Removed!");
            Console.ReadKey();
        }

        private void EnterShop(Plaza plaza)
        {
            Console.WriteLine("Shop name: ");
            ShowShopMenu(plaza.FindShopByName(Console.ReadLine()));
        }

        void ShowShopMenu(IShop shop)
        {
            bool returnPlaza = false;
            while (!returnPlaza)
            {
                Console.Clear();
                System.Console.WriteLine($"Hi! This is the {shop.GetName()}, welcome! Press");
                System.Console.WriteLine("1) to list available products.");
                System.Console.WriteLine("2) to find products by name.");
                System.Console.WriteLine("3) to display the shop's owner.");
                System.Console.WriteLine("4) to open the shop.");
                System.Console.WriteLine("5) to close the shop.");
                System.Console.WriteLine("6) to add new product to the shop.");
                System.Console.WriteLine("7) to add existing products to the shop.");
                System.Console.WriteLine("8) to buy a product by barcode.");
                System.Console.WriteLine("9) check price by barcode.");
                System.Console.WriteLine("N) go back to plaza.");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        ListProducts();
                        break;
                    case "3":
                        Console.WriteLine(shop.GetOwner());
                        Console.ReadKey();
                        break;
                    case "n":
                        returnPlaza = true;
                        break;
                    default:
                        throw new NotSupportedException("No such menu item!");
                }
            }
        }

        private void ListProducts()
        {
            throw new NotImplementedException();
        }
    }
}