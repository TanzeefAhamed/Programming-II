namespace ClassesForDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(1, 1, 2025);
            Console.WriteLine(date1);

            date1.Add(35); 
            Console.WriteLine(date1);

            date1.Add(3, 20); 
            Console.WriteLine(date1);

            Date date2 = new Date(17, 4, 1);

            date1.Add(date2); 
            Console.WriteLine(date1);

            Console.ReadKey();
        }
    }

    class Date
    {
        int day;
        int month;
        int year;

        public Date(int day = 1, int month = 1, int year = 2022)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            Normalize();
        }

        public void Add(int days)
        {
            day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            month += months;
            day += days;
            Normalize();
        }

        public void Add(Date other)
        {
            day += other.day;
            month += other.month;
            year += other.year;
            Normalize();
        }

        private void Normalize()
        {
            while (day > 30)
            {
                day -= 30;
                month++;
            }

            while (month > 12)
            {
                month -= 12;
                year++;
            }
        }

        public override string ToString()
        {
            return ($"The Date today is: {day}/{month}/{year}");
        }
    }
}