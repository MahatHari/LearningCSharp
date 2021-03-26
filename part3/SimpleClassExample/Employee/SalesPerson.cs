using System;
namespace Employees
{
   public class SalesPerson : Employee
    {
        public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numOfSales)
            :base(fullName, age, empId, currPay,ssn, EmployeePayTypeEnum.Commission)
        {
            // Child class property
            SalesNumber = numOfSales;
        }
        public int SalesNumber { get; set; }

        //Default Constructor
        public SalesPerson() { }


        // Overriding Bonus Method
        public override void GiveBonus(float amount)
        {
            int salesBonus;
            if (SalesNumber >=0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Current Sales Number: {SalesNumber}");

        }
    }


    
}
