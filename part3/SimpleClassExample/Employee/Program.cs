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


        }
    }
}
