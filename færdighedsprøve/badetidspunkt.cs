using System;
using System.Collections.Generic;
using System.Text;

namespace færdighedsprøve
{
    class badetidspunkt
    {
        string Type;
        DayOfWeek ugedag;
        DateTime starttidspunkt;
        DateTime sluttidspunkt;
        private string v1;
        private string v2;
        private TimeSpan timeOfDay1;
        private TimeSpan timeOfDay2;
        private string v;
        private DayOfWeek monday;
        private TimeSpan timeOfDay;
        private DateTime t4;

        public badetidspunkt(string type, DayOfWeek DOW, DateTime start, DateTime slut)
        {
            Type = type;
            ugedag = DOW;
            starttidspunkt = start;
            sluttidspunkt = slut;

        }

        public badetidspunkt(string v, DayOfWeek monday, TimeSpan timeOfDay, DateTime t4)
        {
            this.v = v;
            this.monday = monday;
            this.timeOfDay = timeOfDay;
            this.t4 = t4;
        }

        public badetidspunkt(string v, DayOfWeek monday, TimeSpan timeOfDay1, TimeSpan timeOfDay2)
        {
            this.v = v;
            this.monday = monday;
            this.timeOfDay1 = timeOfDay1;
            this.timeOfDay2 = timeOfDay2;
        }
        Dictionary<string, Kreds> badetidsprogram = new Dictionary<string, Kreds>();
        public void AdderKreds(Kreds kreds)
        {
            badetidsprogram.Add(kreds.ID, kreds);
        }
        public void SletKreds(Kreds kreds)
        {
            badetidsprogram.Remove(kreds.ID);
        }

        public override string ToString() { return $"dag { ugedag} start tidspunkt {starttidspunkt.TimeOfDay} slut tidspunkt { sluttidspunkt.TimeOfDay}"; }
        // public static void badetidspunktet()
        // {
        //  if (TimeSpan timeOfDay1 >= TimeSpan timeOfDay2 )
        //    Console.WriteLine( );
        //Console.WriteLine("tidrummet overlapper hinanden prøv igen");

        //  else(TimeSpan timeOfDay1< TimeSpan timeOfDay2)
        //    Console.WriteLine(Console.ReadLine());
        // }
    }
}
