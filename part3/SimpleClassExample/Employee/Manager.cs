using System;
namespace Employees
{
    public class Manager : Employee
    {
        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numOfOpts)
            :base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
        {
            // child class property
            StockOptions = numOfOpts;
        }
        public int StockOptions { get; set; }
        //Default Constructor
        public Manager() { }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        // Overriding DisplayStats

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of stock Options: {StockOptions}");
        }

    }
}
