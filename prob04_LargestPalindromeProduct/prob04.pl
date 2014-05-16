#!/usr/bin/perl

use strict;
use warnings;

my ( $l, $r, $max ) = (0)x3;
for my $x ( reverse(100..999) ) {
    for my $y ( reverse(100..999) ) {
        ( $l, $r, $max ) = ( $x, $y, $x * $y )
            if ( $x * $y > $max && $x * $y == reverse( $x * $y ) );
    }
}
print "l: $l, r: $r, max: $max \n";
