using System;

namespace ObjectOverrides
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Objrect Over rides!");
            Person p1 = new Person();


            Console.WriteLine($"ToString {p1.ToString()}");
            Console.WriteLine($"Hash Code {p1.GetHashCode()}");
            Console.WriteLine($"Type: {p1.GetType()}");

            Person p2 = p1;
            object o = p2;
            // Are the references pointing to the same Object in Memory?

           if(o.Equals(p1)&& p2.Equals(o))
            {
                Console.WriteLine("Same Instances");
            }

        }
    }
}
