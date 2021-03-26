using System;
namespace Employees
{
    public partial class Employee
    {
        //Field Data
        //Protected members are named Pasacal-Cased
        // PascalCased=> EmpName
        protected string EmpName;
        protected int EmpID;
        protected float CurrPay;
        protected int EmpAge;
        protected EmployeePayTypeEnum EmpPayType;
        protected string EmpSsn;


        // Contain a Benefit Pagackage Object
        protected BenefitPackage EmpBenefits = new BenefitPackage();

        //Expose certain benefit behaviors of object
        public double GetBefitCost()
            => EmpBenefits.ComputePayDeduction();

        // Expose Object through a custom Property

        public BenefitPackage Benfits
        {
            get { return EmpBenefits; }
            set { EmpBenefits = value; }
        }


        //Properties
        public string Name
        {
            get => EmpName;
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Max allowed char 14");
                }
                else
                {
                    EmpName = value;
                }
            }
        }
        public int Id
        {
            get => EmpID;
            set => EmpID = value;
        }
        public float Pay
        {
            get => CurrPay;
            set => CurrPay = value;
        }
        public int Age
        {
            get => EmpAge;
            set => EmpAge = value;
        }


        //Social security Number
        //Mixing private and public get/set methods on Properties
        public string SocialSecurityNumber
        {
            get => EmpSsn;
            private set => EmpSsn = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => EmpPayType;
            set => EmpPayType = value;
        }
        public  Employee(){}

        public Employee(string name, int id, float pay, string empSsn)
            : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried)
        {

        }
        

        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }


        //Pattern Matching with Propery Patterns
        public  enum EmployeePayTypeEnum
        {
            Hourly,
            Salaried,
            Commission
        }


        // Public method .. uses enum to find bonus category
        public virtual void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission }
                => Pay += .10F * amount,

                { PayType: EmployeePayTypeEnum.Hourly }
                => Pay += 40F * amount / 2080F,

                { PayType: EmployeePayTypeEnum.Salaried }
                => Pay += amount,

                _ => Pay += 0

            };
        }

        //PolyMorpic Support
        /**
         * Redefining methods with keyword virtual
         * And overriding them in child class using key word override
         */
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
    }
}
