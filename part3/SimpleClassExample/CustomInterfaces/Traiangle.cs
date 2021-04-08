using System;
namespace CustomInterfaces
{
    public class Traiangle:Shape, IPointy
    {
        public Traiangle()
        {
        }
        public Traiangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }
        //IPointy implementaion
        //public byte Points {
        // get {return 3;}
        //}
        public byte Points => 3;
    }
}
