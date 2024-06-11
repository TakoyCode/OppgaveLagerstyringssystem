namespace OppgaveLagerstyringssystem
{
    internal class CommandAddProduct : ICommand
    {
        private Storage _storage;
        public char Char { get; } = 'a';
        public string MenuDesc { get; } = "Add a new product to storage";

        public CommandAddProduct(Storage storage)
        {
            _storage = storage;
        }

        public void Run()
        {
           var newProduct = createProduct();
           if(newProduct != null)
           {
               _storage.AddProduct(newProduct);
           }
        }

        private IProduct createProduct()
        {
            Console.WriteLine("What product do you want to make?");
            Console.WriteLine("1) Electronic");
            Console.WriteLine("2) Food");
            Console.WriteLine("3) Clothes");

            var UserInput = Console.ReadLine();
            if (UserInput == "1")
            {
                var name = Console.ReadLine();
                var price = Convert.ToDouble(Console.ReadLine());
                var warranyInMonths = Convert.ToInt32(Console.ReadLine());

                return new Electronic(name, price, warranyInMonths);
            } 
            else if (UserInput == "2")
            {
                var name = Console.ReadLine();
                var price = Convert.ToDouble(Console.ReadLine());
                var day = Convert.ToInt32(Console.ReadLine());
                var month = Convert.ToInt32(Console.ReadLine());
                var year = Convert.ToInt32(Console.ReadLine());

                return new Food(name, price, day, month, year);
            } 
            else if (UserInput == "3")
            {
                var name = Console.ReadLine();
                var price = Convert.ToDouble(Console.ReadLine());
                var size = Console.ReadLine();

                return new Clothes(name, price, size);
            }
            return null;
        }

    }
}
