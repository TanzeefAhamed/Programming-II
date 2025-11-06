namespace Lab_1__Week_1__Tanzeef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Honda Civic", 2006, 3000, true);
            Console.WriteLine(car1);

            Car car2 = new Car("Kia EV6", 2025, 60000, true);
            Console.WriteLine(car2);

            Car car3 = new Car("Ford Fusion", 2015, 7000, true);
            Console.WriteLine(car3);

            Car car4 = new Car("Toyota Rav 4", 2023, 30000, true);
            Console.WriteLine(car4);
            Console.ReadKey();
        }
    }

    class Car
    {
       string model;
       int year;
       double price;
        bool IsDrivable = true;

        public Car(string model, int year, double price, bool isDrivable = true)
        {
            this.model = model;
            this.year = year;
            this.price = price;
            this.IsDrivable = isDrivable;
        }


        public override string ToString()
        {
            return ($"The Model of the car is: {model}, \n The Year of the car is: {year},\n The Price of The Car Is: {price:c}, \n Is It Drivable {IsDrivable} \n");
        } 
    }
}