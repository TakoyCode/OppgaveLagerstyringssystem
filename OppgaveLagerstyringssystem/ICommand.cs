namespace OppgaveLagerstyringssystem
{
    internal interface ICommand
    {
        char Char { get; }
        string MenuDesc { get; }
        void Run();
    }
}
