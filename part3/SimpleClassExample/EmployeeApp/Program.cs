using System;

namespace EmployeeApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Employee emp = new Employee("Melvin", 456, 30_000);

            // emp._empName = "Marv"; not avaibale due to
            // class protection level

            emp.GiveBonus(1000);
            emp.DisplayStats();

            //Gives error as SetName wont allow more name to be 15 char long
            emp.SetName("Melvinshasdfeadfasrsfs");

            emp.SetName("Melvin Stylish");
            emp.DisplayStats();

            // Updated Employees Class
            // Passed value order is important
            // name id age pay, age can be ommited
            UpdatedEmployee emp2 = new UpdatedEmployee("Hary", 0,  70000);
            emp2.DisplayStats();

        }
    }
}
