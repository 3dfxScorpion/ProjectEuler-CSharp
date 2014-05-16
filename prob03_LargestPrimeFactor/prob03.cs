using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob03 {
    class Tester {
        void Run() {
            ulong max = 0, num = 600851475143;
            ulong limit = Convert.ToUInt32(Math.Sqrt(num)); // 775146
						while ( limit > 2 ) {
                if ( num % limit == 0 ) {
                    if ( chkPrime(limit) ) {
                        max = limit;
                        break;
                    }
                }
                --limit;
            }
            Console.WriteLine("{0} is{1}prime", num, ( chkPrime(num) )
                ? " " : " not ");
            Console.WriteLine("Max: {0}", max);
        }
        bool chkPrime( ulong n ) {
            if ( n == 1 )
                return false;
            if ( n == 2 )
                return true;
            if ( n % 2 == 0 )
                return false;
            if ( n <= 7 )
                return true;
            double sqrt = Math.Sqrt(n);
            uint i = 3;
            while ( i <= sqrt ) {
                if ( n % i == 0 )
                    return false;
                i += 2;
            }
            return true;
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

