using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob04 {
    class Tester {
        void Run() {
            uint count = 0;
            var pals = new SortedSet<uint>();
            for ( uint i = 999; i > 99; i-- ) {
                for ( uint j = 999; j > 99; j-- ) {
                    if ( isPal(i * j) )
                        pals.Add(i * j);
                }
            }
            foreach ( uint pal in pals ) {
                Console.Write(pal + " ");
                if ( ++count % 10 == 0 )
                    Console.WriteLine();
            }
            uint fwd = 12345;
            Console.WriteLine(rev(fwd));
        }
        bool isPal(uint n) {
            string str = new String(n.ToString().Reverse().ToArray());
            return n == uint.Parse(str);
        }
        uint rev(uint n) {
            string str = new String(n.ToString().Reverse().ToArray());
            return uint.Parse(str);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}
