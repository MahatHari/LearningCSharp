using System;
namespace ExceptionHandling
{
    public class Radio
    {
        public Radio()
        {
        }
        public void TurnOn (bool on){
            Console.WriteLine(on? "Jamming.... ": "Quite time-.... ");
        }
    }
}
