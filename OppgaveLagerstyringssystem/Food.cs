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
            Console.WriteLine($"Name: {Name}            Price: {Price}      Expiration Date: {ExpirationDate.getDateAsString()}");
        }
    }
}
