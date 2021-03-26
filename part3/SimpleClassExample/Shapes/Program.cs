using System;

namespace Shapes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Understanding Polymorphic Interface");
            Hexagon hex = new Hexagon("Beth");

            hex.Draw();

            Circle cir = new Circle("Cindy");
            cir.Draw();

            // Make an array of Shape-compatible Objects
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick") };
            //Loop over each item and interact with the polymorphic interface
            foreach(Shape s in myShapes)
            {
                s.Draw();
            }

            // Possibility to trigger the base class implementation of a shadowed member
            // using explict cast

            // This calls shadowed memeber
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            // This calls the Draw method of the Parent

            ((Circle)o).Draw();


        }
    }
}