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
            Console.WriteLine($"Name: {Name}    Price: {Price}       Warranty: {WarrantyInMonths} months");
        }
    }
}
