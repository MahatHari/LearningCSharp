using System;
namespace EmployeeApp
{
    public class UpdateEmployee2
    {
        //Field Data
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private EmployeePayTypeEnum _payType;
        private string _empSsn;

        //Properties
        public string Name
        {
            get => _empName;
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Max allowed char 14");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id 
        {
            get=>_empId;
            set => _empId = value;
        }
        public float Pay
        {
            get => _currPay;
            set => _currPay = value;
        }
        public int Age 
        {
            get=>_empAge;
            set => _empAge = value;
        }
        

        //Social security Number
        //Mixing private and public get/set methods on Properties
        public string SocialSecurityNumber
        {
            get => _empSsn;
            private set => _empSsn = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType=value;
        }

        public UpdateEmployee2( string name, int id, float pay, string empSsn)
            :this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried)
        {

        }

        public UpdateEmployee2(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }
      

        //Pattern Matching with Propery Patterns
        public enum EmployeePayTypeEnum
        {
            Hourly,
            Salaried,
            Commission
        }


        // Public method .. uses enum to find bonus category
        public void GiveBonus(float amount)
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
    }
}
