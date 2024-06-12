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
            var nameInfo = $"Name: {Name}";
            var priceInfo = $"Price: {Price}";
            var sizeInfo = $"Size: {Size}";
            var padLength = 30;
            Console.WriteLine(nameInfo + new string(' ', padLength - nameInfo.Length) +
                              priceInfo + new string(' ', padLength - priceInfo.Length) +
                              sizeInfo);

        }
    }
}
