using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob14 {
    class Tester {
        const uint MAX = 1000000;
        void Run() {
            uint max = 0, sol = 0;
            var cache = new List<uint>();
            var solns = new List<uint>();  // stores solution values
            for ( uint n = 1; n < MAX; n++ ) {
                uint count = 1, num = n;
                cache.Add(n);
                while ( num != 1 ) {
                    num = ( num % 2 == 0 )
                        ? num = num / 2
                        : 3 * num + 1;
                    ++count;
                    cache.Add(num);
                }
                if ( count > max ) {
                    max = count;
                    sol = n;
                    solns = cache.ToList();
                }
                cache.Clear();
            }
            Console.WriteLine("max: {0}, num: {1}\n", max, sol);
            foreach ( uint i in solns )
                Console.Write("{0} ", i);
            Console.WriteLine();
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}
