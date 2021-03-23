using System;
namespace SimpleClassExample
{
    public class MotorCycle
    {
        public int driverIntensity;
        public string driverName;

        public void SetDriverName(string name) => driverName = name;

        public void PopAWheely()
        {
            for(int i=0; i<driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaeeeww");

            }
        }
        //default constructor
        // set all data members to default values;

        public MotorCycle() { }

        // custom constructor
        /*
        public MotorCycle(int intensity)
        {
            driverIntensity = intensity;
        }
        */

        // Redundant constructor logic
        public MotorCycle(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        /*
        public MotorCycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
        */

        /**
         * Constructor Chainaing
         * public Motorcylce(){}
         * public Motorcycle(int intensity)
         *         :this{intensity, ""}
         * public Motorcycle(string name)
         *         :this(0, name){}
         *         
         *         //This is the master constructor
         *         that doess all the real work
         *   publci Motorcycle( int intensity, string name)
         *   {
         *   if(intensity>10){
         *   intensity=10
         *   }
         *   driverIntensity=intensity;
         *   driverName=name;
         *   }
         *   
         *   
         */

        // Single Constructor using optional tags
        public MotorCycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
