namespace OppgaveLagerstyringssystem
{
    internal class CommandRemoveProduct : ICommand
    {
        private Storage _storage;
        public char Char { get; } = 'r';
        public string MenuDesc { get; } = "Remove a product from storage";

        public CommandRemoveProduct(Storage storage)
        {
            _storage = storage;
        }

        public void Run()
        {
            Console.WriteLine("What product would you like to remove?");
           var foundProduct = _storage.GetProductByName(Console.ReadLine());
           if(foundProduct != null)
           {
               _storage.RemoveProduct(foundProduct);
               Console.WriteLine($"Removed product {foundProduct.Name} from storage");
               Thread.Sleep(800);
           }
           else
           {
               Console.WriteLine($"Couldn't find the product you tried remove, please try again.");
                Console.ReadKey(true);
            }
        }
    }
}
