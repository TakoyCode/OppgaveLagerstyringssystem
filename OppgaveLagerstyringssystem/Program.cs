namespace OppgaveLagerstyringssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage();
            storage.ShowProducts();
            
            storage.AddProduct(new Food("Pear", 8.99, 5, 1, 2025));
            storage.AddProduct(new Electronic("Iphones", 7099, 12));
            storage.AddProduct(new Clothes("Jeans", 400, "XL"));
            
            
            storage.ShowProducts();
        }
    }
}
