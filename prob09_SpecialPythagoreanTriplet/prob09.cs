using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob09 {
    class Tester {
        void Run() {
            for ( uint b = 600; b > 299; b-- ) {
                for ( uint a = 300; a > 99; a-- ) {
                    uint c = b*b + a*a, sum = 1000 - ( b + a );
                    if ( Math.Sqrt(c) == sum ) {
                        Console.WriteLine("a: {0}, b: {1}, c: {2}, prod: {3}",
                            a, b, Math.Sqrt(c), a * b * sum);
                    }
                }
            }
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

