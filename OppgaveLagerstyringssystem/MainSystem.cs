namespace OppgaveLagerstyringssystem
{
    internal class MainSystem
    {
        public static void Start()
       {
           var storage = new Storage();
           var commands = new Commands(storage);

           storage.AddProduct(new Food("Pear", 8.99, 5, 1, 2025));
           storage.AddProduct(new Electronic("Iphones", 7099, 12));
           storage.AddProduct(new Clothes("Jeans", 400, "XL"));
           storage.AddProduct(new Food("Apple", 5.99, 20, 12, 2026));
           storage.AddProduct(new Electronic("Dell keyboard", 538, 6));
           storage.AddProduct(new Clothes("t-shirt", 269.77, "M"));

           while (true)
           {
               commands.Show();
               var userInput = Console.ReadKey().KeyChar;
               commands.Run(userInput);
           }
        }

    }
}
