namespace OppgaveLagerstyringssystem
{
    internal class Commands
    {
        private ICommand[] _commands;

        public Commands(Storage storage)
        {
            _commands = new ICommand[]
            {
                new CommandShowProducts(storage),
                new CommandAddProduct(storage),
                new CommandRemoveProduct(storage),
                new CommandExit(),
            };
        }

        public void Show()
        {
            foreach (var command in _commands)
            {
                Console.WriteLine($"{command.Char}) {command.MenuDesc}");
            }
        }

        public void Run(char userInput)
        {
            var command = FindCommand(userInput);
            command?.Run();
        }

        private ICommand? FindCommand(char userInput)
        {
            foreach (var command in _commands)
            {
                if (command.Char == userInput) return command;
            }
            return null;
        }

    }
}
