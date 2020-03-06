using System;
using System.Collections.Generic;

namespace SI4.API
{
    public class Plaza : IPlaza
    {
        public string Name;
        bool isOpen;
        List<IShop> Shops;
        public Plaza(string name)  //ctor
        {
            Name = name;
            Shops = new List<IShop>();
            isOpen = false;
        }
        public void AddShop(IShop shop)
        {
            if (isOpen)
                if (Shops.Contains(shop))
                {
                    throw new ShopAlreadyExistsException();
                }
                else
                {
                    Shops.Add(shop);
                    return;
                }
            throw new PlazaIsClosedException();
        }

        public IShop FindShopByName(string name)
        {
            if (isOpen)
                foreach (IShop shop in Shops)
                {
                    if (shop.GetName().ToLower() == name.ToLower())
                    {
                        return shop;
                    }
                    else
                    {
                        throw new NoSuchShopException();
                    }
                }
            throw new PlazaIsClosedException();
        }

        public List<IShop> GetShops()
        {
            if (isOpen)
                return Shops;
            throw new PlazaIsClosedException();
        }

        public bool IsOpen()
        {
            return isOpen;
        }

        public void Open()
        {
            isOpen = true;
        }

        public void Close()
        {
            isOpen = false;
        }

        public void RemoveShop(IShop shop)
        {
            if (isOpen)
            {
                if (!Shops.Remove(Shops.Find(s => s.Equals(shop))))
                {
                    throw new NoSuchShopException();
                }
                return;
            }
            throw new PlazaIsClosedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}