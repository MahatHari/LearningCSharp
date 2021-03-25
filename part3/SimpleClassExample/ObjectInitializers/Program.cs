using System;

namespace ObjectInitializers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OBJECT INIT SYTNAX");

            // Make a Point by setting each property manuall
            Point firstPoint = new Point();

            firstPoint.X = 10;
            firstPoint.Y = 10;

            firstPoint.DisplayStats();

            // Or make a Point via a Constructor
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Or make a point using Init Syntax
            Point finalPoint = new Point { X=30, Y=30};
            finalPoint.DisplayStats();

            // The default constructor is called implicitly
            Point combinePoint = new Point { X = finalPoint.X, Y = firstPoint.Y };
            combinePoint.DisplayStats();

            // The defualt constructor is called explicitly

            Point exPoint = new Point(){X = firstPoint.Y,Y = anotherPoint.X};
            exPoint.DisplayStats();

        }
    }
}
