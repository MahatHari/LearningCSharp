using static System.Console;
using static System.DateTime;
namespace StaticDataAndMembers
{
    //Static class
    static class TimeUtilClass
    {
        // modified the imports 
        public static void PrintTime()
        {
            WriteLine(Now.ToShortTimeString());
        }
        public static void PrintDate()
            => WriteLine(Today.ToLongDateString());
    }
}
