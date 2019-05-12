using System;


namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var zone = TimeZone.CurrentTimeZone;
            Console.WriteLine(zone.DaylightName);
            Console.ReadKey();
        }
    }
}
