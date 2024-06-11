namespace OppgaveLagerstyringssystem
{
    internal class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public string getDateAsString()
        {
            return $"{_day}/{_month}/{_year}";
        }

    }
}
