using System;
namespace StaticDataAndMembers
{
    public class SavingsAccount

    {
        // Instance-Level Data
        public double currBalance;

        // A static point of data
        public static double _currInterestRate;

        public SavingsAccount(double balance)
        {

            currBalance = balance;
        }
        // A static constructor
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor");
            _currInterestRate = 0.04;
        }


         public static double InterestRate
        {
            get => _currInterestRate;
            set => _currInterestRate = value;
        }
        //static methods(members) to get/set interes Rate the above does
        // exactly the same but in one func
        /*
        public static void SetInterestRate(double newRate)
        {
            _currInterestRate = newRate;
        }

        public static double GetInterestRate()
            => _currInterestRate;
        */
       

    }
}
