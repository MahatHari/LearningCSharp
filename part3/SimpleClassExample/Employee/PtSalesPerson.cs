using System;
namespace Employees
{
    public sealed class PtSalesPerson : SalesPerson
    {
        public PtSalesPerson( string fullName, int age, int empId, float currPay,string ssn, int numOfSales)
            :base (fullName, age, empId, currPay, ssn, numOfSales)
        {
        }
        public PtSalesPerson()
        {

        }
    }
}
