namespace SI4
{
    public abstract class Product
    {
        protected long Barcode { get; private set; }
        protected string Name { get; private set; }
        protected string Manufacturer { get; private set; }
        protected Product(long barcode, string name, string manufacturer)
        {
            Barcode = barcode;
            Name = name;
            Manufacturer = manufacturer;
        }
        public override string ToString()
        {
            return $"Barcode: {Barcode}\nName: {Name}\nManufacturer: {Manufacturer}";
        }
    }
}