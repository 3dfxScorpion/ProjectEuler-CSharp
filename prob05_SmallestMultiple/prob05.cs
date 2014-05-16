using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob05 {
    class Tester {
        void Run() {
            uint s = 2520;
            while ( s < 500000000 ) {
                bool isTrue = true;
                for ( uint i = 10; i < 21; i++ ) {
                    if ( s % i != 0 ) {
                        isTrue = false;
												break;
                    }
                }
                if ( isTrue ) {
                    Console.WriteLine(s);
                    break;
                }
                s += 2520;
            }
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

