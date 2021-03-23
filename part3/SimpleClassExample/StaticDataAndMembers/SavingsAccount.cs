using System;
namespace StaticDataAndMembers
{
    public class SavingsAccount

    {
        // Instance-Level Data
        public double currBalance;

        // A static point of data
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {

            currBalance = balance;
        }
        // A static constructor
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor");
            currInterestRate = 0.04;
        }

        //static methods(members) to get/set interes Rate
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
            => currInterestRate;

       

    }
}
