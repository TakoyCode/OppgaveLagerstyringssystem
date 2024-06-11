namespace OppgaveLagerstyringssystem
{
    internal class CommandExit : ICommand
    {
        public char Char { get; } = 'x';
        public string MenuDesc { get; } = "Exit";
        public void Run()
        {
            Environment.Exit(404);
        }
    }
}
