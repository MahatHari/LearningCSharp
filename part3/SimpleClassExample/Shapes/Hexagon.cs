using System;
namespace Shapes
{
    public class Hexagon :Shape
    {
        //default constructor
        public Hexagon()
        {
        }

        // Inheriated
        public Hexagon(string name): base(name) { }

        public override void Draw()
        {
           
            Console.WriteLine($"Drawing {PetName} from hexagon ");
        }
    }
}
