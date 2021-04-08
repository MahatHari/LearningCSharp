using System;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Exception Example");

            // Creating car and stepping on it
            Car myCar = new Car("Zippy", 20);

            // speeing up past the cars max speed
            // to trigger exception
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("**'*Error *******");
                Console.WriteLine("Member name : {0}", ex.TargetSite);
                Console.WriteLine("Message : {0}", ex.Message);
                Console.WriteLine("Source : {0}", ex.Source);

                // futher details
                Console.WriteLine("Class Defining member : {0}", ex.TargetSite.DeclaringType);
                Console.WriteLine("Memeber Type : {0}", ex.TargetSite.MemberType);
                Console.WriteLine("Member attributes : {0}", ex.TargetSite.Attributes);

                //stack trace
                Console.WriteLine("Stack : {0}", ex.StackTrace);
            }

           
        }
    }
}
