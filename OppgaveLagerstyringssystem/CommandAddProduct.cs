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

            var UserInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (UserInput == '1')
            {
                return MakeElectronic();
            } 
            else if (UserInput == '2')
            {
                return MakeFood();
            } 
            else if (UserInput == '3')
            {
                return MakeClothes();
            }
            return null;
        }

        private IProduct MakeClothes()
        {
            Console.WriteLine("What name would you like the product to have?");
            var name = Console.ReadLine();
            Console.WriteLine("What price would you like the product to have?");
            if (!Double.TryParse(Console.ReadLine(), out double price))
            {
                ErrorMessage();
                return null;
            }
            Console.WriteLine("What size would you like the product to have?");
            var size = Console.ReadLine();

            return new Clothes(name, price, size);
        }

        private IProduct MakeFood()
        {
            Console.WriteLine("What name would you like the product to have?");
            var name = Console.ReadLine();
            Console.WriteLine("What price would you like the product to have?");
            if (!Double.TryParse(Console.ReadLine(), out double price))
            {
                ErrorMessage();
                return null;
            }
                
            Console.WriteLine("Which year does the product expire?");
            if (!Int32.TryParse(Console.ReadLine(), out int year))
            {
                ErrorMessage();
                return null;
            }
            Console.WriteLine("Which month does the product expire?");
            if (!Int32.TryParse(Console.ReadLine(), out int month))
            {
                ErrorMessage();
                return null;
            }
            Console.WriteLine("Which day does the product expire?");
            if (!Int32.TryParse(Console.ReadLine(), out int day))
            {
                ErrorMessage();
                return null;
            }

            return new Food(name, price, day, month, year);
        }

        private IProduct MakeElectronic()
        {
            Console.WriteLine("What name would you like the product to have?");
            var name = Console.ReadLine();

            Console.WriteLine("What price would you like the product to have?");
            if (!Double.TryParse(Console.ReadLine(), out double price))
            {
                ErrorMessage();
                return null;
            }

            Console.WriteLine("Write the how many months the warranty lasts");
            if (!Int32.TryParse(Console.ReadLine(), out int warrantyInMonths))
            {
                ErrorMessage();
                return null;
            }

            return new Electronic(name, price, warrantyInMonths);
        }

        private void ErrorMessage()
        {
            Console.WriteLine("Something went wrong, please try again");
            Thread.Sleep(800);
        }
    }
}
