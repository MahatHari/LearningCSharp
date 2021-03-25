using System;

namespace AutoProps
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            c.PetName = "Frank";
            c.Color = "Red";
            c.Speed = 30;

            Console.WriteLine($"Your car is Named {c.PetName}");
            c.DisplayStats();


            // Create Garage Instance 
            Garage g = new Garage();

            // ok prints default value of zero
            Console.WriteLine($"Number of Cars { g.NumberOfCars} ");

            // Runtime Error !! Backing filed is currently Null
            //Console.WriteLine($"Number of Cars { g.myAuto.PetName} ");

            // Put car in the garage

            g.myAuto = c;

            Console.WriteLine($"Number of Cars { g.myAuto.PetName} ");
            Console.WriteLine($"Number of Cars { g.NumberOfCars} ");


        }
    }
}
