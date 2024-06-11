namespace OppgaveLagerstyringssystem
{
    internal class Clothes : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }

        public Clothes(string name, double price, string size)
        {
            Name = name;
            Price = price;
            Size = size;
        }

        public void PrintOutInfo()
        {
            Console.WriteLine($"Name: {Name}          Price: {Price}    Size: {Size}");
        }
    }
}
