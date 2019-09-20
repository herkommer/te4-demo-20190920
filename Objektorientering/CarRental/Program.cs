using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Car, stand by.");

            Car c;
            c = new Car();

            c.RegistrationNumber = "ABC123";
            c.HorsePower = 170;
            c.Color = "Black";

            Console.WriteLine("Car created");
            Console.ReadLine();

            Console.WriteLine("We have a {0} car, with registration {1} and {2}hp",
                                c.Color,
                                c.RegistrationNumber,
                                c.HorsePower);
        }
    }

    class Car
    {
        public string RegistrationNumber { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }

    }
}
