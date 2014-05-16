using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob03 {
    class Tester {
        void Run() {
            ulong num = 0;
            do {
                Console.WriteLine("Enter number");
                Console.Write("    (18446744073709551615 max, '0' to exit): ");
                try {
                    num = ulong.Parse(Console.ReadLine());
                }
                catch(Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine("{0} is{1}prime", num, ( chkPrime(num) )
                    ? " " : " not ");
            } while ( num > 0 );
        }
        bool chkPrime( ulong n ) {
            if ( n == 1 )
                return false;
            if ( n == 2 )
                return true;
            if ( n % 2 == 0 )
                return true;
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

