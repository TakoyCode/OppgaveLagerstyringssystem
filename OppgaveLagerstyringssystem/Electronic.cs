using System.Runtime.InteropServices.JavaScript;

namespace OppgaveLagerstyringssystem
{
    internal class Electronic : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int WarrantyInMonths { get; set; }

        public Electronic(string name, double price, int warrantyInMonths)
        {
            Name = name;
            Price = price;
            WarrantyInMonths = warrantyInMonths;
        }

        public void PrintOutInfo()
        {
            var nameInfo = $"Name: {Name}";
            var priceInfo = $"Price: {Price}";
            var warrantyInfo = $"Warranty: {WarrantyInMonths} months";
            var padLength = 30;
            Console.WriteLine(nameInfo + new string(' ', padLength - nameInfo.Length) +
                              priceInfo + new string(' ', padLength - priceInfo.Length) +
                              warrantyInfo);
        }
    }
}
