#!/usr/bin/perl

use strict;
use warnings;

my @array = (1, 1);
my $num;

do {
#for (0..10) {
    ( $array[-2], $array[-1] ) = ( $array[-1], ( $array[-1] + $array[-2] ) );
    $num = $array[-1]
} while ( length($array[-1]) < 10 );

print scalar(@array), "\n";
print "num: $num\n";
