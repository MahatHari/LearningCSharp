using System;

namespace RefTypeValTypeParams
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Passing ref-types by Value
            Console.WriteLine("*****Passing Person Object by value*****");
            Person fred = new Person("Fred", 34);

            Console.WriteLine("\n Before by value call, Person is");
            fred.Display();

            SendAPersonByValue(fred);
            Console.WriteLine("\n After by value call, Person is");
            fred.Display();

            //Passing ref-types by ref

            Console.WriteLine("****** Passing Person Object by Reference *****");

            Person mel = new Person("Melvin", 23);
            Console.WriteLine("Before by ref call, Person is");
            mel.Display();

            /** Returned the whole new Person Object ***/
            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call, Person is");
            mel.Display();

            /* Changed only the value of age property of the Person Object*/
            // Passing ref types by value
            SendAPersonByValue(mel);
            mel.Display();


            // WORKING WITH DATABASEREADER CLASS
            Console.WriteLine("*** Fun with Nullable Vlaue Types **** \n");
            DatabaseReader dr = new DatabaseReader();

            //If the value from GetIntFromDatabase is null
            // assign local variable to 100

            int myData = dr.GetIntFromDatabase()??100;

            Console.WriteLine("Value of myData: {0}", myData);

            //Get int from 'database'
            int? i = dr.GetIntFromDatabase();

            if (i.HasValue)
            {
                Console.WriteLine("Value of i is {0}", i.Value);
            }
            else
            {
                Console.WriteLine(" Value of i is undefined");
            }


            //Get Bool from 'database'

            bool? b = dr.GetBooleanFromDatabase();

            if (b != null)
            {
                Console.WriteLine("Value of b is {0}", b.Value);
            }
            else
            {
                Console.WriteLine(" Value of b is undefined");
            }

            //Null Coealesicng Assignment Operation( c#8.0)

            /* This operator assigns the left hand side to the righthand side only if the 
             the left hand side is null
             */

            int? nullableInt = null;
            nullableInt ??= 24; // assigns nullableInt the value of 24 as is null
            nullableInt ??= 14; // does not assign as nullableInt already has a value of 24
            Console.WriteLine(nullableInt);
            string ? [] nullableString = { "ASD", "ASDF" };
            TesterMethod(args: nullableString);


            //Tuples => Getting starting with Tuples

            (string, int, string) values = ("a", 2, "b");
            // also follwing is valid
            var values2 = ("x", 2, "z");

            // Accessing  tuple elements
            Console.WriteLine($" First Item: {values.Item1}");
            Console.WriteLine($" First Item: {values.Item2}");
            Console.WriteLine($" First Item: {values.Item3}");


            // Name values tuple
            (string firstName, string lastName, int age) info = ("Hari", "Mahat", 34);

            // can be accesed by ItemX= Item position, 1 in above is firstName
            Console.WriteLine($" First Name: {info.Item1}");

            // accing using name
            Console.WriteLine($" First Item: {info.lastName}");

            // values with Names
            var info2 = (firstName: "Hari", lastName:"Mahat", age: 23);


            // Calling Tuple as Methods Return values

            var samples = FillTheseValues2();
            Console.WriteLine($" Int is {samples.a}");
            Console.WriteLine($" String is {samples.b}");
            Console.WriteLine($" Boolean is {samples.c}");

            // Destructed Tuple allows singple method call to get the individaul values of the
            // structre by returning a tuple

            Point p = new Point(-5, 6);
            var pointValues = p.Deconstruct();
            Console.WriteLine($" X is : {pointValues.xPos}");
            Console.WriteLine($" Y is : {pointValues.yPos}");

            // Using tuple value to get quadrant

            Console.WriteLine(GetQuadtrant1(p));




        }
        static void SendAPersonByValue(Person p)
        {
            // change the age of "p"
            p.personAge = 99;

            // Will the caller see this reassignment
            p = new Person("Nikki", 99);
        }

        //Passing Reference Types by Reference
        static void SendAPersonByReference(ref Person p)
        {
            //change some data of p;
            p.personAge = 555;

            // p is now pointing to new Object on the heap
            p = new Person("Nikki", 999);
        }

        //Nullable Value Types
        static void LocalNullableVariables()
        {
            //Define some local nullable varibles ? is shorthand for using
            // Nullable<T>
            int? nullabelInt = 10;
            double? nullableDouble = null;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[19];
        }

        //using Nullable<T>
        static void LocalNullableVariablesUsingNullable()
        {
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 2.3;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }

        // Testing Null values
        static void TesterMethod(string [] args)
        {
            // We chould check fro null before acesing the array data
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments");
        }

        // Tuple As Method Return Values

        static void FillTheseValues (out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your testing";
            c = true;
        }

        //By using tuple, above method can be written removing parameters

        static (int a, string b, bool c) FillTheseValues2()
        {
            return (9, "Enjoy your string.", true);
        }

        // Deconstruting Tuples
        /**
         * destructing is the term given when separting out the properties of 
         * a tuple to be used individually
         */
        struct Point
        {
            // Fileds of the structure
            public int X;
            public int Y;

            //A custom constructor
            public Point(int Xpos, int Ypos)
            {
                X = Xpos;
                Y = Ypos;
            }

            public (int xPos, int yPos) Deconstruct() => (X, Y);
        }

        // Deconstructing Tuples with Positional Patter Matching

        static string GetQuadtrant1(Point p)
        {
            return p.Deconstruct() switch
            {
                (0, 0) => "Origin",
                var (x, y) when x > 0 && y > 0 => "One",
                var (x, y) when x < 0 && y > 0 => "Two",
                var (x, y) when x > 0 && y < 0 => "Three",
                var (x, y) when x > y && y < 0 => "Four",
                var (_, _) => "Border",
            };
        }



    }
}
