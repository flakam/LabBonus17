using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {         
            
            List<Car> cars = new List<Car>();
            Car c1 = new UsedCar(2011, "Ford", "Taurus", 20000, 199000);
            Car c2 = new Car(2019, "Chevy", "Malibu", 10000);
            Car c3 = new UsedCar(2011, "Lamborghini", "Aventador", 345000, 1200);
            Car c4 = new Car(2019, "Ferrari", "Italia", 400000);
            Car c5 = new UsedCar(2019, "Bentley", "Mulsanne", 500000, 1234);
            Car c6 = new Car(2019, "Toyota", "Camry", 200000);

            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(c4);
            cars.Add(c5);
            cars.Add(c6);
            Console.WriteLine("Which car do you want to select?Enter a number: 1- 6");
           
                for (int k = 0; k < cars.Count; k++)
                {
                  int t = k + 1;

                 Car nn = cars[k];

                              
                  Console.WriteLine($"{t} {cars[k]}");
                 }
            
                   

               
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                Console.WriteLine(cars[0]);
                }
                else if (s == 2)
                {
                Console.WriteLine(cars[1]);

            }
                else if (s == 3)
                {
                Console.WriteLine(cars[2]);
            }
                else if (s == 4)
                {
                Console.WriteLine(cars[3]);
            }
                else if (s == 5)
                {
                Console.WriteLine(cars[4]);
            }
                else if (s == 6)
                {
                Console.WriteLine(cars[5]);
            }
            Console.WriteLine("Would you like to buy the car?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                cars.RemoveAt(s-1);
               
            }
            else if(answer=="n")
            {
                Console.WriteLine("Thank you");
            }
            for (int k = 0; k < cars.Count; k++)
            {
                int t = k + 1;

                Car nn = cars[k];


                Console.WriteLine($"{t} {cars[k]}");
            }

        }

     }
}


