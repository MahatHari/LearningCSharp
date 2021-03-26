using System;
namespace Employees
{
    // This new type will function as a contained class
    public class BenefitPackage
    {
        public BenefitPackage()
        {
        }
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
}
