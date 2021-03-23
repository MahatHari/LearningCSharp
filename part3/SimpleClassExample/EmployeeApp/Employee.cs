using System;
namespace EmployeeApp
{
    public class Employee
    {
        //Field Data
        private string _empName;
        private int _empId;
        private float _currPay;

        //Accessor (get method)
        public string GetName() => _empName;

        //Mutator (set method)
        public  void  SetName(string name)
        {
            // Do check on incoming valu
            // before making assignment
            if (name.Length > 15)
            {
                Console.WriteLine("Error!! Name length exceeds 15 characters");
            }
            else
            {
                _empName = name;
            }
        }

        //Constructors
        public Employee()
        {
        }
        public Employee (string name, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
        }


        //Methods
        public void GiveBonus(float amount) => _currPay += amount;

        public void DisplayStats()
        {
            Console.WriteLine($"Name : {_empName}");
            Console.WriteLine($"ID : {_empId}");
            Console.WriteLine($"Pay : {_currPay}");
        }
    }
}
