#!/usr/bin/perl

use strict;
use warnings;

my ( $goal, $max ) = ( $ARGV[0] || 10001, $ARGV[1] || 200000 );
$max = $goal * 20 if $goal / $max > 0.05;
my @primes;

genList();

sub genList {
my ( $j, @tested ) = (1) x 2;
    while ( @primes < $goal ) {
        next if $tested[$j++];
        push ( @primes, $j );
        for ( my $k =  ($j**2); $k <= $max; $k += $j ) {
            $tested[$k-1]= 1;
        }
    }
}

print scalar(@primes), "'s prime is ", $primes[$#primes], "\n";
