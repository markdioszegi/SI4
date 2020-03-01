namespace SI4
{
    public class ClothingProduct : Product
    {
        string Material { get; set; }
        string Type { get; set; }
        public ClothingProduct(long barcode, string name, string manufacturer, string material, string type) : base(barcode, name, manufacturer)
        {
            Material = material;
            Type = type;
        }
    }
}