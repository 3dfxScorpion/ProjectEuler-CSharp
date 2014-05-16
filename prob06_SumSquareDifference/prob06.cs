using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob06 {
    class Tester {
        void Run() {
            uint sqr = 0, sum = 0;
            for ( uint i = 1; i < 101; i++ ) {
                sum += i*i;
                sqr += i;
            }
            Console.WriteLine("{0}", Math.Abs(sum - Math.Pow(sqr, 2)));
            Console.WriteLine("{0}", Math.Pow(sqr, 2) - sum);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

