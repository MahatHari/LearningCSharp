using System;
namespace Shapes
{
    public class ThreeDCircle:Circle
    {
        // Member Shadowing
        // Hide any Draw() implementation above me
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circl");
        }

        // new keyword can be applied to any memeber type inherited from a base class
        //(filed constant, static member or property )

        // Hide the PetName Property above me
        public new string PetName { get; set; }
        public ThreeDCircle()
        {
        }
    }
}
