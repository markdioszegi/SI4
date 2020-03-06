using System;
using System.Collections.Generic;

namespace SI4.API
{
    public interface IPlaza
    {
        List<IShop> GetShops();
        void AddShop(IShop shop);
        void RemoveShop(IShop shop);
        IShop FindShopByName(String name);
        bool IsOpen();
        void Open();
        void Close();
        string ToString();
    }
}