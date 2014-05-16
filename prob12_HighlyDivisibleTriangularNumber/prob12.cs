using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob12 {
    class Tester {
        void Run() {
            ulong count = 1, num = 10;
            for ( uint i = 1; i < num; i++ ) {
                double ele = 0.5 * ( i * i ) + 0.5 * i;
                Console.WriteLine("ele: {0}", ele);
                for ( uint j = 1; j < ele / 2; j++ ) {
                    if ( ele % j == 0 ) {
                        ++count;
                    }
                }
            }
            Console.WriteLine("count: {0}", count);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

