using System;
using System.Collections.Generic;
using System.Text;

namespace færdighedsprøve
{
    class badeprogram
    {




        public class badetidspunkt
        {
            Dictionary<string, Kreds> badetidsprogram = new Dictionary<string, Kreds>();
            public void AdderKreds(Kreds kreds)
            {
                badetidsprogram.Add(kreds.ID, kreds);
            }
            public void SletKreds(Kreds kreds)
            {
                badetidsprogram.Remove(kreds.ID);
            }


        }
    }
}
