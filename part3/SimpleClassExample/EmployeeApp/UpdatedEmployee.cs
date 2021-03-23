using System;
namespace EmployeeApp
{
    public class UpdatedEmployee
    {
        //Field Data
        private string _empName;
        private float _currPay;
        private int _empId;
        private int _empAge;

        //Properties
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Erro! Name cant be longer than 15 characters");
                }
                else
                {
                    _empName = value;

                }
            }
        }


        // The 'int' represents the type of data this property encapsulates
        public int Id { get => _empId; set => _empId = value; }

        // Short hand Property, 
        public float Pay { get => _currPay; set => _currPay = value; }

        public int Age { get => _empAge; set => _empAge = value; }


        //Updated Constructor
        public UpdatedEmployee()
        {

        }
        public UpdatedEmployee (string name, int id, float pay):this(name, id, 0, pay)
        {

        }
        public UpdatedEmployee(string name, int id, int age, float pay)
        {
            _empName = name;
            _empId = id;
            _empAge = age;
            _currPay = pay;
        }

        //Updated Display stats () method now accounts for age
        public void DisplayStats()
        {
            Console.WriteLine($" Name: {_empName}");
            Console.WriteLine($" Age: {_empAge}");
            Console.WriteLine($" Id: {_empId}");
            Console.WriteLine($" Pay: {_currPay}");
        }
    }
}
