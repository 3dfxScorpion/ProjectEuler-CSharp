using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Prob11 {
    class Tester {
        void Run() {
            string perlFile = "temp.pl";
            string pScript = @"#!/usr/bin/perl 

use strict;
use warnings;

my $i = shift || 20;
for (1..$i) {
    print join( "" "",
        map { my $n = int( 100*rand() );
            ( $n < 10 ) ? ""0"" . $n : $n;
        } (1..$i)
    ), ""\n"";
}
";
            using (StreamWriter sw = new StreamWriter(perlFile))  {
                sw.WriteLine(pScript);
            }
            // confiure Perl number generator
            string perlCommand = @"C:\cygwin\bin\perl.exe";
            string perlScript = perlFile;
            Console.Write("Enter desired array size [20]: ");
            string perlArg = Console.ReadLine();
            int readInt;
            if ( !int.TryParse( perlArg, out readInt ) )
                perlArg = "20";
            ProcessStartInfo perlStartInfo =
                new ProcessStartInfo(perlCommand);
            perlStartInfo.Arguments = perlScript + " " + perlArg;
            perlStartInfo.UseShellExecute = false;
            perlStartInfo.RedirectStandardOutput = true;
            // execute Perl number generator
            Process perl = new Process();
            perl.StartInfo = perlStartInfo;
            perl.Start();
            string data = perl.StandardOutput.ReadToEnd();
            perl.WaitForExit();
            perl.Close();
            File.Delete(perlFile);
            // display working array data
            Console.WriteLine("Using:\n{0}", data);
            // process raw data into List
            var iList = new List<int[]> ();
            string cin = null;
            string rePattern = @"\b\d+\b";
            using ( var fr = new StringReader(data)) {
                while ( ( cin = fr.ReadLine() ) != null )
                    iList.Add(Regex.Matches(cin, rePattern)
                        .OfType<Match>()
                        .Select(m => int.Parse(m.Groups[0].Value))
                        .ToArray());
            }
            // set some variables
            int smpl  = 4;                   // sample size
            int iSize = iList.Count;         // List size
            int iters = iSize - smpl;        // iteration count
            int last  = iSize - 1;           // last List index
            // work on horizontal and vertical
            uint hmax = 1, vmax = 1;
            for ( int z = 0; z <= iters; z ++ ) {
                for ( int y = 0; y < iSize; y ++ ) {
                    uint h = 1, v = 1;
                    for ( int x = 0; x < smpl; x ++ ) {
                        h *= Convert.ToUInt32(iList[y][x + z]);
                        v *= Convert.ToUInt32(iList[x + z][y]);
                    }
                    hmax = ( h > hmax ) ? h : hmax;
                    vmax = ( v > vmax ) ? v : vmax;
                }
            }
            // work on the diagonals
            uint umax = 1, dmax = 1;
            for ( int z = 0; z <= iters; z ++ ) {
                for ( int y = 0; y <= iters; y ++ ) {
                    int offset = 0;
                    uint u = 1, d = 1;
                    for ( int x = 0; x < smpl; x ++ ) {
                        u *= Convert.ToUInt32(iList[last - y - offset][x + z]);
                        d *= Convert.ToUInt32(iList[x + z][y + offset++]);
                    }
                    umax = ( u > umax ) ? u : umax;
                    dmax = ( d > dmax ) ? d : dmax;
                }
            }
            // find a winner
            uint max = ( hmax > vmax )
                ? ( umax > dmax )
                    ? ( hmax > umax ) ? hmax : umax
                        : ( hmax > dmax ) ? hmax : dmax
                : ( umax > dmax )
                    ? ( vmax > umax ) ? vmax : umax
                    : ( vmax > dmax ) ? vmax : dmax;
            Console.WriteLine("hmax: {0}, vmax: {1}", hmax, vmax);
            Console.WriteLine("umax: {0}, dmax: {1}", umax, dmax);
            Console.WriteLine("winner: {0}", max);
        }
        static void Main() {
            Tester t = new Tester();
            t.Run();
        }
    }
}
