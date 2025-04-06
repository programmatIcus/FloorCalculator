namespace FloorAndCarpetApp
{
    public class Material
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public Material(string name, string type, decimal price)
        {
            Name = name;
            Type = type;
            Price = price;
        }


    }
}
