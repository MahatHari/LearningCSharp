using System;
namespace RefTypeValTypeParams
{
    public class DatabaseReader
       
    {
        public int? numericValue = 120;
        public bool? boolValue = true;

        //Note the nullable return type
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        public bool? GetBooleanFromDatabase()
        {
            return boolValue;
        }
        public DatabaseReader()
        {
           
        }
    }
}
