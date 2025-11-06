using System;
using System.Collections.Generic;
using System.Linq;
using LinqDataLib;

namespace QuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleWithHighAssets();
            PeopleOutsideUS();
            FemaleNamesFromIndia();
            FirstNamesLessThanFive();
            SortByAssetOnlyNameAndAmount();
            GroupByCountry();
            SortGroupedByCountry();
            CustomQuery1();
            CustomQuery2();
            CustomQuery3();
            Console.ReadKey();
        }

        static void PeopleWithHighAssets()
        {
            Console.WriteLine("\n | People with assets over 50B dollars |");

            var result = from p in Person.persons
                         where p.Asset > 50
                         select p;

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}, Asset: {person.Asset}B");
            }
        }

        static void PeopleOutsideUS()
        {
            Console.WriteLine("\n | All non-US Citizens | ");

            var result = from p in Person.persons
                         where p.Country != "US"
                         select p;

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}, Country: {person.Country}");
            }
        }

        static void FemaleNamesFromIndia()
        {
            Console.WriteLine("\n | Names of females from India | ");

            var result = from p in Person.persons
                         where p.Country == "India" && p.IsFemale
                         select p.Name;

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        static void FirstNamesLessThanFive()
        {
            Console.WriteLine("\n | People with first names less than 5 letters | ");

            var result = from p in Person.persons
                         where p.Name.Split()[0].Length < 5
                         select p;

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}");
            }
        }

        static void SortByAssetOnlyNameAndAmount()
        {
            Console.WriteLine("\n | People sorted by asset (name and asset only) | ");

            var result = from p in Person.persons
                         orderby p.Asset
                         select new { p.Name, p.Asset };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Asset}B");
            }
        }

        static void GroupByCountry()
        {
            Console.WriteLine("\n | Grouping people by country | ");

            var result = from p in Person.persons
                         group p by p.Country into groups
                         select groups;

            foreach (var group in result)
            {
                Console.WriteLine($"\nCountry: {group.Key} ({group.Count()} people)");
                foreach (var person in group)
                {
                    Console.WriteLine($"  {person.Name}");
                }
            }
        }

        static void SortGroupedByCountry()
        {
            Console.WriteLine("\n | Grouping by country and sorting by country name | ");

            var result = from p in Person.persons
                         group p by p.Country into grouped
                         orderby grouped.Key
                         select grouped;

            foreach (var group in result)
            {
                Console.WriteLine($"\nCountry: {group.Key} ({group.Count()} people)");
                foreach (var person in group)
                {
                    Console.WriteLine($"  {person.Name}");
                }
            }
        }

        static void CustomQuery1()
        {
            Console.WriteLine("\n | Top 3 oldest people | ");

            var result = (from p in Person.persons
                          orderby p.Age descending
                          select p).Take(3);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }
        }

        static void CustomQuery2()
        {
            Console.WriteLine("\n | People grouped by gender | ");

            var result = from p in Person.persons
                         group p by p.IsFemale into g
                         select new { Gender = g.Key ? "Female" : "Male", Group = g };

            foreach (var group in result)
            {
                Console.WriteLine($"\nGender: {group.Gender} ({group.Group.Count()} people)");
                foreach (var person in group.Group)
                {
                    Console.WriteLine($"  {person.Name}");
                }
            }
        }

        static void CustomQuery3()
        {
            Console.WriteLine("\n | People aged 60 or older grouped by decade | ");

            var result = from p in Person.persons
                         where p.Age >= 60
                         group p by (p.Age / 10) * 10 into ageGroups
                         orderby ageGroups.Key
                         select ageGroups;

            foreach (var group in result)
            {
                Console.WriteLine($"\nAge Group: {group.Key}s ({group.Count()} people)");
                foreach (var person in group)
                {
                    Console.WriteLine($"  {person.Name}, Age: {person.Age}");
                }
            }
        }
    }
}
