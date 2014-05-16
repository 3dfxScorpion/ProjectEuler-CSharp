#!/usr/bin/perl

use strict;
use warnings;

my $abc = prod();

print "prod: $abc\n";

sub prod {
    for my $i ( 1..300 ) {
        for my $j ( 1..400 ) {
            next unless $j > $i;
            my ( $x, $y, $z ) = ( $i**2, $j**2, 1000 - ($i + $j) );
            print "$i, $j, $z\n" and return $i * $j * $z
                if ( ( $i + $j + $z ) == 1000 && $z == sqrt($x + $y) );
        }
    }
}
