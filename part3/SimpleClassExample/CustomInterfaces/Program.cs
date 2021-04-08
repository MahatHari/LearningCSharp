using System;

namespace CustomInterfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A first look at Interfaces");
            CloneableExample();


            // Call Points property defined by IPointy
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points : {0}", hex.Points);

            // Catch a possible InvalidCastException
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;

            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            // Can we treat hex2 as IPointy

            Hexagon hex2 = new Hexagon();
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null)
            {
                Console.WriteLine("Points {0} ", itfPt2.Points);
            }
            else
            {
                Console.WriteLine("Not implementaed");
            }
            //Obtaining Interface References : The is Keyword
            Hexagon hex3 = new Hexagon();
            if(hex3 is IPointy itfPt3)
            {
                Console.WriteLine("Points {0} ", itfPt3.Points);
            }
            else
            {
                Console.WriteLine("Not implementaed");
            }

            // Square
            IRegularPointy sq = new Square("Boxy") { NumberOfSides = 4, SideLength = 4 };
            sq.Draw();

            //

        }
        public static void CloneableExample()
        {
            // all of theese classes suppor the Icolneable Interfac
            string mystr = "Hello";
            OperatingSystem unixOx = new OperatingSystem(PlatformID.Unix, new Version());

            // there fore they can all be passed into a method taking ICloneable
            CloneMe(mystr);
            CloneMe(unixOx);

             static void CloneMe(ICloneable c)
            {
                object theClone = c.Clone();
                Console.WriteLine("Your clone is : {0}", theClone.GetType());
            }
        }
    }
}
