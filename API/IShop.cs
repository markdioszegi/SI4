using System.Collections.Generic;

namespace SI4.API
{
    public interface IShop
    {
        string GetName();
        string GetOwner();
        bool IsOpen();
        void Open();
        void Close();
        List<Product> GetProducts();
        Product FindByName(string name);
        float GetPrice(long barcode);
        bool HasProduct(long barcode);
        void AddNewProduct(Product product, int quantity, float price);
        void AddProduct(long barcode, int quantity);
        Product BuyProduct(long barcode);
        List<Product> BuyProducts(long barcode, int quantity);
        string ToString();
    }
}