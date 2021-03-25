using System;
namespace AutoProps
{
    public class Garage
        
    {
        // Hidded int backing filed is set to One // by default Zero
        public int NumberOfCars { get; set; } = 1;

        // The hidded Car backing field is set to a new Car Object by Default NUll
        public Car myAuto { get; set; } = new Car();

        // Must use Constructores to override default
        // values assigned to hidded backing fileds.
        public Garage()
        {
            myAuto = new Car();
            NumberOfCars = 1;

        }
        public Garage(Car car, int number)
        {
            myAuto = car;
            NumberOfCars = number;
        }
    }
}
