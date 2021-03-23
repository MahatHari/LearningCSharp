using System;
namespace RefTypeValTypeParams
{
    public class Person
    {
        public string personName;
        public int personAge;

        //Constructor
        public Person( string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }

        public void Display()
        {
            Console.WriteLine($"Name :  {personName}, Age: {personAge}");
        }

        
    }
}
