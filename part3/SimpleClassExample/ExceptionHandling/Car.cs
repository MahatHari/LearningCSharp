using System;
namespace ExceptionHandling
{
    public class Car
    {
        // Constant for maximum speed
        public const int MaxSpeed = 100;


        // Car Properties
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // Is the car still operational
        private bool _carIsDead;

        // Car has-a radio
        private readonly Radio _theMusicBox = new Radio();
        //constructors
        public Car()

        {
        }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        // See if Car has overheader

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order ...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    //Console.WriteLine($"{PetName} has over heated");
                    CurrentSpeed = 0;
                    _carIsDead = true;

                    // Use the "throw" keyword to raise and exception
                    throw new Exception($" {PetName} has over heated!");
                }
                else
                {
                    Console.WriteLine($"=>Current Speed = {CurrentSpeed}");
                }
            }
        }
    }
}
