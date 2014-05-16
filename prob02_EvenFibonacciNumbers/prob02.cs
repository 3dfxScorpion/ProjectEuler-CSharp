using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob02 {
    class Tester {
        static void Main() {
            int sum = 0;
            var fibs = new List<int> { 1, 2 };
            int c = fibs.Count - 1;
            while ( fibs[c] < 4000000 ) {
                fibs.Add( fibs[c--] + fibs[c++] );
                if ( fibs[c] % 2 == 0 )
                    sum += fibs[c];
								c++;
            }
            Console.WriteLine("sum: {0}", sum);
        }
    }
}

