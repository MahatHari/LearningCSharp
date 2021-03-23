using System;

namespace StaticDataAndMembers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Saving Account Class");

            //three instances of SavingAccount

            SavingsAccount s1 = new SavingsAccount(50);

            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine($" Interest Rate is {SavingsAccount.GetInterestRate()}");


            /**
             *  The static data is shared by all objects of same
             *  category meaning .. currInterestRate is same for
             *  all savingAccount s1,s2 and s3 or any other created
             */

            //pring the current InterestRate
            Console.WriteLine($" Interest Rate is {SavingsAccount.GetInterestRate()}");
            SavingsAccount.SetInterestRate(0.8);

            SavingsAccount s4 = new SavingsAccount(10000.75);
            Console.WriteLine($" Interest Rate is {SavingsAccount.GetInterestRate()}");
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine($" Interest Rate is {SavingsAccount.GetInterestRate()}");


            // Calling Static Class
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();


        }
    }
}
