using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob01 {
    class Tester {
        void Run() {
            int sum = 0;
            for ( int i = 3; i < 1000; i++ )
                if ( ( i % 3 == 0 ) || ( i % 5 == 0 ) )
                    sum += i;
            Console.WriteLine("sum: {0}", sum);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}

