using System.Drawing;

namespace MedalColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);
            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);

            List<Medal> medals = new List<Medal>() { m1, m2 };

            medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Sidney Crosby", "Ice Hockey", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));

           
            Console.WriteLine("All of the 16 medals");
            int count = 1;
            foreach (Medal medal in medals)
            {
                Console.WriteLine($"{count}. {medal}");
                count++;
            }

            Console.WriteLine("\nAll the names for 16 medals");
            count = 1;
            foreach (Medal medal in medals)
            {
                Console.WriteLine($"{count}. {medal.Name}");
                count++;
            }

            Console.WriteLine("\nAll the names for 9 gold medals");
            count = 1;
            foreach (Medal medal in medals)
            {
                if (medal.Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{count}. {medal.Name}");
                    count++;
                }
            }

           
            Console.WriteLine("\nAll the names for 9 medals in 2012");
            count = 1;
            foreach (Medal medal in medals)
            {
                if (medal.Year == 2012)
                {
                    Console.WriteLine($"{count}. {medal.Name}");
                    count++;
                }
            }

            Console.WriteLine("\nAll the names for 4 medals in 2012");
            count = 1;
            foreach (Medal medal in medals)
            {
                if (medal.Year == 2012 && medal.Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{count}. {medal.Name}");
                    count++;
                }
            }

            
            Console.WriteLine("\nAll the names for 3 world record medals");
            count = 1;
            foreach (Medal medal in medals)
            {
                if (medal.IsRecord)
                {
                    Console.WriteLine($"{count}. {medal.Name}");
                    count++;
                }
            }

            
            Console.WriteLine("\nSaving all the medals to file Medals.txt");
            StreamWriter writer = new StreamWriter("Medals.txt");
            foreach (Medal medal in medals)
            {
                writer.WriteLine(medal);
            }
            Console.ReadKey();
        }

        enum MedalColor
        {
            Gold,
            Silver,
            Bronze
        }


        class Medal
        {
            public string Name { get; }
            public string TheEvent { get; }
            public MedalColor Color { get; }
            public int Year { get; }
            public bool IsRecord { get; }

            public Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
            {
                Name = name;
                TheEvent = theEvent;
                Color = color;
                Year = year;
                isRecord = isRecord;
            }

            public override string ToString()
            {
                return $"{Name}, {TheEvent}, {Color}, {Year}, {IsRecord}";
            }

        }
    }
}
