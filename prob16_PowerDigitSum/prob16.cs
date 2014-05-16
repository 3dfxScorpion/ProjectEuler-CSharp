using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Prob16 {
    class Tester {
        void Run() {
            BigInteger tot = 0;
            string sSum = new BigInteger(Math.Pow(2, 1000)).ToString();
            Console.WriteLine("2^1000: {0}", sSum);
            foreach ( char s in sSum )
                tot += BigInteger.Parse(s.ToString());
            Console.WriteLine("total: {0}", tot.ToString());
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

