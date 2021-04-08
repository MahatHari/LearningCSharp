using System;

namespace ObjectOverrides
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Objrect Over rides!");
            Person p1 = new Person( "Homer", "Simposon", 50, "129023-80");
            Person p2= new Person("Homer", "Simposon", 50, "129023-80");

            // GET Stringified version of objects
            Console.WriteLine($"ToString : {p1.ToString()}");
            Console.WriteLine($"ToString : {p2.ToString()}");
            Console.WriteLine($"Hash Code {p1.GetHashCode()}");
            Console.WriteLine($"Type: {p1.GetType()}");

            // Test overridden Equals

            Console.WriteLine($"p1= p2? : {p1.Equals(p2)}");


            // Test hash codes
            // still using the hash of ssn
            Console.WriteLine($"Same hash codes {p1.GetHashCode()==p2.GetHashCode()}" );


            // change age of p2 and test again
            p2.Age = 45;
            Console.WriteLine("ToString {0}:", p1.ToString());
            Console.WriteLine($"ToString : {p2.ToString()}");
            Console.WriteLine($"p1= p2? : {p1.Equals(p2)}");
            Console.WriteLine($"Same hash codes {p1.GetHashCode() == p2.GetHashCode()}");




        }
    }
}
