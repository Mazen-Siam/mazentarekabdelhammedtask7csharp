using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7csharp
{
    

    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0.0;
        }

        public Car(int id)
        {
            Id = id;
            Brand = "Unknown";
            Price = 0.0;
        }

        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = 0.0;
        }

        public Car(int id, string brand, double price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Brand: {Brand}, Price: {Price}");
        }
    }

    class program
    {
        static void Main()
        {
            Car car1 = new Car(); 
            Car car2 = new Car(101); 
            Car car3 = new Car(102, "Toyota"); 
            Car car4 = new Car(103, "BMW", 50000); 

            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();
        }
    }
}
