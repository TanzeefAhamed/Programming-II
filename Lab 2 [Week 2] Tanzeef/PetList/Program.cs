namespace PetList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pets> pets = new List<Pets>();

            Pets pet1 = new Pets("Fluffy", 4, "Persian Cat", "Micheal");
            Pets pet2 = new Pets("Spike", 2, "Bulldog", "Micheal");
            Pets pet3 = new Pets("Mittens", 1, "Siamese Cat", "Lexi");
            Pets pet4 = new Pets("Buddy", 3, "Golden Retriever", "Lexi");

            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);
            pets.Add(pet4);

            Console.WriteLine("\nThe Owner Micheal Owns: Persian Cat (Fluffy), Bulldog (Spike) \nThe Owner Lexi Owns: Golden Retriever (Buddy), Siamese Cat (Mittens)");

            Console.WriteLine("\nWhat is the name of the owner of the pets?");
            string owner = Console.ReadLine();
            bool ownerFound = false;

            foreach (Pets pet in pets)
            {
                if (pet.Owner == owner)
                {
                    Console.WriteLine($"Name: {pet.Name}, Age: {pet.Age}, Description: {pet.Description} ");
                    ownerFound = true;
                }
            }

            if (!ownerFound)
            {
                Console.WriteLine("The owner does not own any pets");
            }

            Console.ReadKey();
        }
    }

    class Pets
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public bool IsHouseTrained { get; set; }

        public Pets(string name, int age, string description, string owner)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = owner;
        }

        public void Train()
        {
            IsHouseTrained = true;
        }
        public void SetOwner(string owner)
        {
            Owner = owner;
        }

        public override string ToString()
        {
            return $"{Name}, {Owner}, {Age}, {Description}, {IsHouseTrained}";
        }
    }
}