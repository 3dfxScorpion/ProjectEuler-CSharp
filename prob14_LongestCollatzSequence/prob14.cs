using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob14 {
    class Tester {
        const uint MAX = 1000000;
        void Run() {
            uint max = 0, sol = 0;
            for ( uint n = 1; n < MAX; n++ ) {
                uint count = 1, num = n;
                while ( num != 1 ) {
                    num = ( num % 2 == 0 )
                        ? num / 2
                        : 3 * num + 1;
                    ++count;
                }
                if ( count > max ) {
                    max = count;
                    sol = n;
                }
            }
            Console.WriteLine("max: {0}, num: {1}\n", max, sol);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}
