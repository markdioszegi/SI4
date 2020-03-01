using System.Collections.Generic;

namespace SI4
{
    public class Shop : IShop
    {
        string Name;
        string Owner;
        Dictionary<long, Shop.ShopEntry> Products;
        public Shop(string name, string owner)     //ctor
        {
            Name = name;
            Owner = owner;
        }
        public void AddNewProduct(Product product, int quantity, float price)
        {
            throw new System.NotImplementedException();
        }

        public void AddProduct(long barcode, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public Product BuyProduct(long barcode)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Product> BuyProducts(long barcode, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public Product FindByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return Name;
        }

        public string GetOwner()
        {
            return Owner;
        }

        public float GetPrice(long barcode)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public bool HasProduct(long barcode)
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

        class ShopEntry
        {
            Product Product { get; set; }
            int Quantity { get; set; }
            float Price { get; set; }
            ShopEntry(Product product, int quantity, float price)
            {

            }
            public void IncreaseQuantity(int amount)
            {
                Quantity += amount;
            }
            public void DecreaseQuantity(int amount)
            {
                Quantity -= amount;
            }
            public override string ToString()
            {
                return $"Product: {Product}\nQuantity: {Quantity}\nPrice: {Price}";
            }
        }
    }
}