namespace OppgaveLagerstyringssystem
{
    internal interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }

        void PrintOutInfo();
    }
}
