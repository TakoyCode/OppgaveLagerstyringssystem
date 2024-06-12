namespace OppgaveLagerstyringssystem
{
    internal class CommandShowProducts : ICommand
    {
        private Storage _storage;
        public char Char { get; } = 's';
        public string MenuDesc { get; } = "Show all products in storage";

        public CommandShowProducts(Storage storage)
        {
            _storage = storage;
        }

        public void Run()
        {
            _storage.ShowProducts();
            Console.ReadKey(true);
        }
    }
}
