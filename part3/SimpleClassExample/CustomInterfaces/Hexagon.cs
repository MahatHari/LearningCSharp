using System;
namespace CustomInterfaces
{
    public class Hexagon :Shape, IPointy
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
        public byte Points => 6;
    }
}
