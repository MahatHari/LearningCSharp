using System;

namespace SimpleClassExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Fun With Class Types ****");
            Car myCar = new Car
            {
                currSpeed = 10,
                petName = "Jetta"
            };

            // speed up the car a few times and print our the new stat

            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            //Invoking the default Constructor
            Car chuck = new Car();

            // Prints Chuck is going 10 MPH
            chuck.PrintState();

            // Make  a Car called Marry going 0MPH
            Car mary = new Car("Mary");
            mary.PrintState();

            // Make a Car called Daisy going 75MPH
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();


            // Using default constructor on Motorcycle class
            Console.WriteLine("MotorCycle Class");
            MotorCycle mc = new MotorCycle();
            mc.PopAWheely();

            // make Motorcyle with a rider named Tiny

            MotorCycle c = new MotorCycle(5);
            c.SetDriverName ("Tiny");
           
            c.PopAWheely();
            Console.WriteLine($" Rider name is  {c.driverName}");

            MakeSomeBikes();
        }
        static void MakeSomeBikes()
        {
            // driverName= "", dirverIntensity =0

            MotorCycle m1 = new MotorCycle();
            Console.WriteLine($"Name {m1.driverName}, Intensity = {m1.driverIntensity}");

            // driverName = "Tiny " driverIntensity=0

            MotorCycle m2 = new MotorCycle(name:"Tiny");
            Console.WriteLine($"Name {m1.driverName}, Intensity = {m1.driverIntensity}");

            //driver Name = "" driverIntensity =7
            MotorCycle m3 = new MotorCycle(intensity:7);
            Console.WriteLine($"Name {m1.driverName}, Intensity = {m1.driverIntensity}");

        }
    }
}
