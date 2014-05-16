using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob07 {
    class Tester {
        void Run() {
            ulong target = 10001, limit = 2000000;
            var sieveList = new List<ulong>();
            genList(sieveList, limit, target);
            Console.WriteLine("{0}'s prime is {1}",
                target, sieveList[sieveList.Count - 1]);
        }
        void genList(List<ulong> list, ulong max, ulong goal) {
            ulong i = 1;
            var temp = new ulong[max];
            while ( Convert.ToUInt32(list.Count) < goal ) {
                if ( temp[i++] == 1 )
                    continue;
                list.Add(i);
                for ( ulong j = i * i; j <= max; j += i )
                    temp[j - 1] = 1;
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
