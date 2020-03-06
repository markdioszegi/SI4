namespace SI4.API
{
    public class ClothingProduct : Product
    {
        public string Material { get; set; }
        public string Type { get; set; }
        public ClothingProduct(long barcode, string name, string manufacturer, string material, string type) : base(barcode, name, manufacturer)
        {
            Material = material;
            Type = type;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nMaterial: {Material}\nType: {Type}";
        }
    }
}