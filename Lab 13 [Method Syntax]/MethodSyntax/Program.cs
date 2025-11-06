using System;
using System.Collections.Generic;
using System.Linq;
using LinqDataLib;

namespace LinqMethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowNonUSCitizens();
            ListUSCitizenNames();
            DisplayIndianFemales();
            SortStudentsByName();
            GroupPeopleByGender();
            FindLongestWord();
            WordWithMostVowels();
            CombineSetsWithoutDuplicates();
            RunJoinsOnFruitsAndPersons();
            Console.ReadKey();
        }

        static void ShowNonUSCitizens()
        {
            Console.WriteLine("\n | People NOT from US | ");
            var result = Person.persons.Where(p => p.Country != "US");

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} from {person.Country}");
            }
        }

        static void ListUSCitizenNames()
        {
            Console.WriteLine("\n | Names of US Citizens | ");
            var result = Person.persons
                .Where(p => p.Country == "US")
                .Select(p => p.Name);

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        static void DisplayIndianFemales()
        {
            Console.WriteLine("\n | Females from India |");
            var result = Person.persons
                .Where(p => p.Country == "India" && p.IsFemale);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} ({person.Country})");
            }
        }

        static void SortStudentsByName()
        {
            Console.WriteLine("\n | Students Sorted by Last, then First Name |");
            var sorted = Student.students
                .OrderBy(s => s.Last)
                .ThenBy(s => s.First);

            foreach (var s in sorted)
            {
                Console.WriteLine($"{s.First} {s.Last}");
            }
        }

        static void GroupPeopleByGender()
        {
            Console.WriteLine("\n | People Grouped by Gender |");
            //var grouped = Person.persons.GroupBy(p => p.IsFemale ? "Female" : "Male");
            var grouped = Person.persons.GroupBy(p => p.Country).OrderBy(g => g.Count());


            foreach (var group in grouped)
            {
                Console.WriteLine($"\n{group.Key}s:");
                foreach (var person in group)
                {
                    Console.WriteLine(person.Name);
                }
            }
        }

        static void FindLongestWord()
        {
            Console.WriteLine("\n | Longest Word |");
            string[] words = "the quick brown fox jumps over the lazy dog".Split();

            var longest = words.Aggregate((a, b) => a.Length >= b.Length ? a : b);

            Console.WriteLine($"Longest word is: {longest}");
        }

        static void WordWithMostVowels()
        {
            Console.WriteLine("\n | Word with Most Vowels |");
            string[] words = "the quick brown fox jumps over the lazy dog".Split();

            var mostVowels = words.Aggregate((a, b) => CountVowels(a) >= CountVowels(b) ? a : b);

            Console.WriteLine($"Most vowels in: {mostVowels}");
        }

        static int CountVowels(string word)
        {
            return word.ToLower().Count(c => "aeiou".Contains(c));
        }

        static void CombineSetsWithoutDuplicates()
        {
            Console.WriteLine("\n | Combined Sets (No Duplicates) |");
            string[] setA = "a b c e".Split();
            string[] setB = "a c d e".Split();

            var combined = setA.Concat(setB)
                .GroupBy(x => x)
                .Select(g => g.Key)
                .OrderBy(x => x);

            Console.WriteLine("Unique values:");
            foreach (var item in combined)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void RunJoinsOnFruitsAndPersons()
        {
            Console.WriteLine("\n | INNER JOIN (Same Country) |");
            var inner = Person.persons.Join(Fruit.fruits,
                p => p.Country,
                f => f.Origin,
                (p, f) => new { PersonName = p.Name, FruitName = f.Name, p.Country });

            foreach (var pair in inner)
            {
                Console.WriteLine($"{pair.PersonName} matches fruit {pair.FruitName} from {pair.Country}");
            }

            Console.WriteLine("\n | LEFT JOIN (All Persons) |");
            var leftJoin = from p in Person.persons
                           join f in Fruit.fruits on p.Country equals f.Origin into pf
                           from fruit in pf.DefaultIfEmpty()
                           select new
                           {
                               PersonName = p.Name,
                               FruitName = fruit != null ? fruit.Name : "No Fruit"
                           };

            foreach (var result in leftJoin)
            {
                Console.WriteLine($"{result.PersonName} - {result.FruitName}");
            }

            Console.WriteLine("\n |  RIGHT JOIN (All Fruits) |");
            var rightJoin = from f in Fruit.fruits
                            join p in Person.persons on f.Origin equals p.Country into fp
                            from person in fp.DefaultIfEmpty()
                            select new
                            {
                                Fruit = f.Name,
                                Person = person != null ? person.Name : "No Match"
                            };

            foreach (var result in rightJoin)
            {
                Console.WriteLine($"{result.Fruit} - {result.Person}");
            }
        }
    }
}