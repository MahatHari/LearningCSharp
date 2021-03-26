using System;

namespace Employees
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SalesPerson fred = new SalesPerson
            {
                Age = 31,
                Name = "Fred",
                SalesNumber = 50
            };

            // extending PtSalesPerson from SalesPerson

            PtSalesPerson partTime1 = new PtSalesPerson
            {
                Name="Hari",
                Age=31,
                Id=2342,
                SalesNumber=40,
                Pay=234.4F,
            };


            //Manager
            Manager chucky = new Manager("Chucky", 50, 92, 1000000, "333-2332-s23", 9000);
            double cost = chucky.GetBefitCost();
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson frank = new SalesPerson("Fran", 43, 93, 3000, "9333-32-3232", 31);
            frank.GiveBonus(200);
            frank.DisplayStats();
            Console.WriteLine();

            CastingExamples();

          
        }
        static void CastingExamples()
        {
            // A manager 'is-a' System.Object, so we can
            // store a manager refrence in an object variable just fine
            object franky = new Manager("Franky", 9, 3000, 40000, "asdfw-222-121", 5);

            //Type Casting
            // (ClassIwantToCastTo)referenceIHave
            GivePromotions((Manager)franky);

            // A manage 'is-a" Employee too

            Employee moonUnit = new Manager(" Mooshy", 8, 23, 234234, "dfgw-234", 7);
            GivePromotions(moonUnit);

            // A PtSales person 'is-a' salses person
            SalesPerson jill = new SalesPerson("Jill", 834, 3002, 10000, "sdfg3-23-23", 90);
        }
        static void GivePromotions(Employee emp)
        {
            Console.WriteLine($"{emp.Name} is Promoted");

            //using is Keyword, is keyword returns false/true, and as keyword returns null if not compatible
            /*
            if(emp is SalesPerson)
            {
                Console.WriteLine($"{emp.Name} made {((SalesPerson)emp).SalesNumber}");
                Console.WriteLine();
            }else if(emp is Manager)
            {
                Console.WriteLine($"{emp.Name} has {((Manager)emp).StockOptions} stock options .. ");
                Console.WriteLine( );

            }
            */

            // The above code can be written by assigin is out come to a variable then no double casting is needed
            // current in above code there is double casting op first in if statement then inside the loop

            // s is the variable that holds value if emp is SalesPerson is true

            /*
            if(emp is SalesPerson s)
            {
                Console.WriteLine($"{s.Name} made {s.SalesNumber}");
            }else if(emp is Manager m)
            {
                Console.WriteLine($"{m.Name} made {m.StockOptions}");
            }
            */

             // Using Swith Statements for type casting
             switch (emp)
            {
                case SalesPerson s when s.SalesNumber > 5:
                    Console.WriteLine($"{s.Name} made {s.SalesNumber}");
                        break;
                case Manager m:
                    Console.WriteLine($"{m.Name} made {m.StockOptions}");
                    break;
                case Employee _:
                    Console.WriteLine($"Promabse cant be Give to Wrong Employee {emp.Name}");
                    break;
            }

        }
    }
}
