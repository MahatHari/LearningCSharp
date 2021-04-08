using System;
namespace ObjectOverrides
{
    public class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; }

        public Person(string fName, string lName, int personAge, string ssn)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
            SSN = ssn;
        }

        public Person()
        {

        }
        // Return hash code based on unique string data
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
