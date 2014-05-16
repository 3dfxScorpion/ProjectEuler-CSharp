using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob04 {
    class Tester {
        void Run() {
            uint max = 0, l = 0, r = 0;
            for ( uint i = 999; i > 99; i-- ) {
                for ( uint j = 999; j > 99; j-- ) {
                    if ( ( i * j > max ) && isPal(i * j) ) {
                        max = i * j; l = i; r = j;
                    }
                }
            }
            Console.WriteLine("l: {0}, r: {1}, max: {2}", l, r, max);
        }
        bool isPal(uint n) {
            string str = new String(n.ToString().Reverse().ToArray());
            return n == uint.Parse(str);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}
