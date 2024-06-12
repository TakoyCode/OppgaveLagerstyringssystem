using System.Drawing;

namespace OppgaveLagerstyringssystem
{
    internal class Food : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Date ExpirationDate { get; set; }

        public Food(string name, double price, int day, int month, int year)
        {
            Name = name;
            Price = price;
            ExpirationDate = new Date(day, month, year);
        }

        public void PrintOutInfo()
        {
            var nameInfo = $"Name: {Name}";
            var priceInfo = $"Price: {Price}";
            var expirationDateInfo = $"Expiration Date: {ExpirationDate.getDateAsString()}";
            var padLength = 30;
            Console.WriteLine(nameInfo + new string(' ', padLength - nameInfo.Length) +
                              priceInfo + new string(' ', padLength - priceInfo.Length) +
                              expirationDateInfo);
        }
    }
}
