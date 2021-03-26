using System;
namespace ObjectInitializers
{
    public enum PointColor { ligtBlue, BloodRed, Gold }
    public class Point
    {
        
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public  Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor) {
        Color= ptColor;
        }
        public Point()
            : this(PointColor.BloodRed) { }
        
        public void DisplayStats()
        {
            Console.WriteLine($"[{X}, {Y}]");
            Console.WriteLine($"Point is {Color}");
        }
    }
}
