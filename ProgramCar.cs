using System.ComponentModel;
using System.Numerics;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("BMW", "M3", 2003);
        car.Info();
        car.CalculateAge();
    }

    public class Car
    {
        public string brand;
        public string model;
        public int YearOfCreation;

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.YearOfCreation = year;
        }

        public void Info()
        {
            Console.WriteLine($"Your car is {brand} {model} crated in {YearOfCreation}");
        }

        public void CalculateAge()
        {
            int age = 2024 - YearOfCreation;
            Console.WriteLine($"Your car is {age} years old");
        }

    }
}