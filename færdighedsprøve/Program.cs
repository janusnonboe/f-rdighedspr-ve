using System;

namespace færdighedsprøve
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreds K1 = new Kreds("en", "Osted", "Maghrettevej 12", 32);
            Kreds K2 = new Kreds("to", "Roskilde", "maglegård 12", 16);
            DateTime T1 = new DateTime().AddHours(10).AddMinutes(55);
            DateTime T3 = new DateTime().AddHours(11).AddMinutes(55);
            DateTime T2 = new DateTime().AddHours(14).AddMinutes(35);
            DateTime T4 = new DateTime().AddHours(15).AddMinutes(35);
            badetidspunkt B1 = new badetidspunkt("morgen turen", DayOfWeek.Monday,  T1, T3);
            badetidspunkt B2 = new badetidspunkt("eftermiddags turen", DayOfWeek.Monday, T2, T4);
            Console.WriteLine(K1.ToString());
            Console.WriteLine( B1.ToString());

            Console.WriteLine(K2.ToString());
            Console.WriteLine(B2.ToString());

            B1.AdderKreds(K1);
            Console.WriteLine(B1);
        }

    }
}
