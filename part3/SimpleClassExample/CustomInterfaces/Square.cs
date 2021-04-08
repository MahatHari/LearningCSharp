using System;
namespace CustomInterfaces
{
    public class Square: Shape, IRegularPointy
    {
        public Square()
        {
        }
        public Square(string name) : base(name)
        {

        }
        // Draw comes from the shape base class
        public override void Draw()
        {
            Console.WriteLine("Drawing a Swuare");
        }

        // comes from IPointy interface
        public byte Points => 4;

        // comes from RegularPointy interface
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
    }
}
