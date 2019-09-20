﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList Cars = new System.Collections.ArrayList();

            Car c = new Car();
            c.Make = "Volvo";
            c.Model = "V70";
            c.Color = "Black";

            Cars.Add(c);

            Car d = new Car() { Make="Audi", Model="A4", Color="White" };
            Cars.Add(d);

            Cars.Add(new Car() { Make = "BMW", Model = "i8", Color = "Red" });


            Console.WriteLine("Vi har {0} st bilar i lager just nu", Cars.Count);

            foreach (Car anka in Cars)
            {
                Console.WriteLine("{0} {1}", anka.Make,anka.Model);
            }
        }
    }
}
