using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumChk {
    class Tester {
        void Run(ulong g = 2000, ulong l = 200000) {
            ulong target = g, limit = l;
            var sieveList = new List<ulong>();
            try {
                genList(sieveList, limit, target);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Prime number {0} out of {1} is {2}",
                target, limit, sieveList[sieveList.Count - 1]);
            Console.Write("show list? [n] : ");
            string choice = Console.ReadLine();
						if ( choice == "y" ) {
                foreach ( ulong prime in sieveList ) {
                    Console.Write("{0} ", prime);
                }
            }
        }
        void genList(List<ulong> list, ulong max, ulong goal) {
            ulong i = 1;
            if ( ( Convert.ToDouble(goal) / Convert.ToDouble(max) ) > 0.05 ) {
                Console.WriteLine("Increasing range to {0} to accomodate goal",
                    goal * 20);
                max = goal * 20;
            }
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
            var args = new string[2];
            Console.Write("nth prime to find [2000] : ");
            args[0] = Console.ReadLine();
            Console.Write("out of how many integers [200000] : ");
            args[1] = Console.ReadLine();
            if (args[0] == "")
                args[0] = "2000";
            if (args[1] == "")
                args[1] = "200000";
            t.Run(ulong.Parse(args[0]), ulong.Parse(args[1]));
        }
    }
}
