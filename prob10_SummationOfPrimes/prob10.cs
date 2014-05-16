using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob10 {
    class Tester {
        void Run() {
            ulong limit = 2000000, sum = 0;
            var sieveList = new List<ulong>();
            genList(sieveList, limit);
            foreach ( ulong prime in sieveList )
                sum += prime;
            Console.WriteLine("Sum: {0}", sum);
        }
        void genList(List<ulong> list, ulong max) {
            ulong i = 1;
            var temp = new ulong[max];
            while ( i < max ) {
                if ( temp[i++] == 1 )
                    continue;
                list.Add(i);
                for ( ulong j = i * i; j <= max; j += i )
                    temp[j - 1] = 1;
            }
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

