using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_XX_XX {
    class Tester {
        void Run() {
            const double CENTER = 1;
            double array = 1001;
            double range = array / 2;
            double tot = 1;
            for ( double r = 2; r <= range + CENTER; r++ ) {
                tot += 4 * Math.Pow( r, 2 ) - 10 * r + 7;    /* 3, 13, 31... */
                tot += 4 * Math.Pow( r, 2 ) -  8 * r + 5;    /* 5, 17, 37... */
                tot += 4 * Math.Pow( r, 2 ) -  6 * r + 3;    /* 7, 21, 43... */
                tot += 4 * Math.Pow( r, 2 ) -  4 * r + 1;    /* 9, 25, 49... */
            }
            Console.WriteLine("total: {0}", tot);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

