using System;
using System.Collections.Generic;

namespace SI4
{
    public interface IPlaza
    {
        List<Shop> GetShops();
        void AddShop(Shop shop);
        void RemoveShop(Shop shop);
        Shop FindShopByName(String name);
        bool IsOpen();
        void Open();
        void Close();
        String ToString();
    }
}