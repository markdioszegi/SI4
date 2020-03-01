using System;
using System.Collections.Generic;

namespace SI4
{
    public class Plaza : IPlaza
    {
        List<Shop> Shops;
        public Plaza()  //ctor
        {

        }
        public void AddShop(Shop shop)
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public Shop FindShopByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Shop> GetShops()
        {
            throw new System.NotImplementedException();
        }

        public bool IsOpen()
        {
            throw new System.NotImplementedException();
        }

        public void Open()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveShop(Shop shop)
        {
            throw new System.NotImplementedException();
        }
    }
}