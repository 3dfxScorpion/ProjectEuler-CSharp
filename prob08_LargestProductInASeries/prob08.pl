#!/usr/bin/perl

use strict;
use warnings;

## Problem 08 -
## Find the greatest product of five
## consecutive digits in an x-digit number.

my $arg = shift || 0;

my $smStr = <<DATA;
12345
67890
12345
67890
12345
67890
DATA

my $lgStr = <<DATA;
73167176531330624919225119674426574742355349194934
96983520312774506326239578318016984801869478851843
85861560789112949495459501737958331952853208805511
12540698747158523863050715693290963295227443043557
66896648950445244523161731856403098711121722383113
62229893423380308135336276614282806444486645238749
30358907296290491560440772390713810515859307960866
70172427121883998797908792274921901699720888093776
65727333001053367881220235421809751254540594752243
52584907711670556013604839586446706324415722155397
53697817977846174064955149290862569321978468622482
83972241375657056057490261407972968652414535100474
82166370484403199890008895243450658541227588666881
16427171479924442928230863465674813919123162824586
17866458359124566529476545682848912883142607690042
24219022671055626321111109370544217506941658960408
07198403850962455444362981230987879927244284909188
84580156166097919133875499200524063689912560717606
05886116467109405077541002256983155200055935729725
71636269561882670428252483600823257530420752963450
DATA

my $data = ( $arg ) ? $lgStr : $smStr;
printf "%s string\n$data\n", ( $arg ) ? "Large" : "Small";
print "rMax: ", rMax($data), "\n";
print "sMax: ", sMax($data), "\n";
print "aMax: ", aMax($data), "\n";

exit;

sub rMax { # Regex Example
    my $max = 0;
    # remove spaces and store as string
    my $str= join( '', split( /\s/, shift ) );
    print "Showing regex progression of string\n" unless $arg;
    while ( $str =~ /(?=(\d)(\d)(\d)(\d)(\d))/gc ) {
        my $string = $1 . $2 . $3 . $4 . $5;
        my $series = $1 * $2 * $3 * $4 * $5;
        print ">>", $string, "<<\n" unless $arg;
        $max = ( $max > $series ) ? $max : $series;
    }
    return $max;
}

sub sMax { # Substr Example
    my $max = 0;
    my $prod = 1;
    # remove spaces and store as string
    my $str= join( '', split( /\s/, shift ) );
    my $size = length($str);
    for my $s ( 0..$size - 5 ) {
        for my $p ( $s..$s + 4 ) {
            $prod *= substr($str, $p, 1);
        }
        $max = ( $prod > $max ) ? $prod : $max;
        $prod = 1;
    }
    return $max;
}

sub aMax { # Index Example
    my $max = 0;
    my $prod = 1;
    # remove spaces and store as array
    my @array = grep( /\d/, split( //, shift ) );
    my $size = @array;
    for my $s ( 0..$size - 5 ) {
        for my $p ( $s..$s + 4 ) {
            $prod *= $array[$p];
        }
        $max = ( $prod > $max ) ? $prod : $max;
        $prod = 1;
    }
    return $max;
}
