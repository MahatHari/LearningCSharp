using System;
namespace AutoProps
{
    public class Car
    {
        // Automatc Properts ! No need to define backing fileds
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public Car()
        {
        }
        public Car(string name, int speed, string color)
        {
            PetName = name;
            Speed = speed;
            Color = color;
        }
        public void DisplayStats()
        {
            Console.WriteLine($" Car Name {PetName}");
            Console.WriteLine($" Car Name {Speed}");
            Console.WriteLine($" Car Name {Color}");
        }
             
        
    }
}
