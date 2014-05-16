#!/usr/bin/perl

use strict;
use warnings;

my (@array, $sum);

do {
    push @array, ( $array[-1] || 0 ) + ( $array[-2] || 1 );
    $sum += $array[-1] unless ( $array[-1] % 2 );
} while ( $array[-1] < 4_000_000 );

print "sum: $sum\n";
