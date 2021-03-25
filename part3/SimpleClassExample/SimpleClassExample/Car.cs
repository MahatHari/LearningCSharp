using System;
namespace SimpleClassExample
{
    public class Car
    {
        // State of the car
        public string petName;
        public int currSpeed;

        // The functionality of the Car
        // using the expression-bodied member syntax
        public void PrintState()
        => System.Console.WriteLine($"{petName} is going {currSpeed} MPH");

        public void SpeedUp(int delta)
        => currSpeed += delta;

        // A constructor  is a special method of a class which is indirectly called when
        // creating an object using new keyword. However unlike other methods constructor
        // never have a return value (not even void) and are always named identically to
        // the class they are constructing

        // A custom default Constructor
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // Defining Custom Constructors
        // Here currSpee will revieve
        // the default value of an int zero
        public Car(string pn)
        {
            petName = pn;
        }

        //let caller set full state of the car
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public Car(string pn, int cs, out bool inDanger)
        {
            petName = pn;
            currSpeed = cs;
            if (cs > 180)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        // The above can be done in following manner
        // Automatic Properties ! No need to define backing fields
        /*
         * Public string PetName{get; set;}
         * Public string Speed{get; set;}
         * Public string Color{get; set;}
         */
    }
}
