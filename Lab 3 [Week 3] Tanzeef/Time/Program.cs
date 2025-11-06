namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Time> times = new List<Time>()
            {
                new Time(9, 35),
                new Time(18, 5),
                new Time(20, 50),
                new Time(10),
                new Time()
            };

            TimeFormat format = TimeFormat.Hour12;
            Console.WriteLine($"Time format is {format}");
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            format = TimeFormat.Mil;
            Console.WriteLine($"\nSet time format to {format}");
            Time.SetFormat(format);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            format = TimeFormat.Hour24;
            Console.WriteLine($"\nSet time format to {format}");
            Time.SetFormat(format);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();
        }
    }

    public enum TimeFormat
    {
        Mil,
        Hour12,
        Hour24
    }

    public class Time
    {
        private static TimeFormat TIME_FORMAT { get; set; } = TimeFormat.Hour12;
        public int Hour { get;  }
        public int Minute { get;  }
        public Time(int hour = 0, int minute = 0)
        {
            if (hour >= 0 && hour < 24)
            {
                Hour = hour;
            }
            else
            {
                Hour = 0;
            }

            if (minute >= 0 && minute < 60)
            {
                Minute = minute;
            }
            else
            {
                Minute = 0;
            }
        }
        public static void SetFormat(TimeFormat timeFormat)
        {
            TIME_FORMAT = timeFormat;
        }

        public override string ToString()
        {
            if (TIME_FORMAT == TimeFormat.Mil)
            {
                return $"{Hour:D2}{Minute:D2}";
            }
            else if (TIME_FORMAT == TimeFormat.Hour24)
            {
                return $"{Hour:D2}:{Minute:D2}";
            }
            else if (TIME_FORMAT == TimeFormat.Hour12)
            {
                int hour12 = Hour % 12;
                if (hour12 == 0) hour12 = 12;
                string amPm = Hour < 12 ? "AM" : "PM";
                return $"{hour12:D2}:{Minute:D2} {amPm}";
            }
            else
            {
                return $"{Hour:D2}:{Minute:D2}";
            }
        }
    }
}