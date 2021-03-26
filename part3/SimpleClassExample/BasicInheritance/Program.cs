using System;

// is-a "Inheritance " has-a => Containment/delegation
namespace BasicInheritance
{
    class MainClass
    {
        class MyClass
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Basic Inheritance ");

            // Make a Car Object, set Max speed and current Speed
            Car myCar = new Car(80) { Speed = 50 };

            //Print current speed
            Console.WriteLine($"My car is going at {myCar.Speed}");

            // Mini Can Object

            MiniVan myVan = new MiniVan() ;
            myVan.Speed=53;
            
            Console.WriteLine($"My miniVan is going at {myVan.Speed}");


        }
    }
}
