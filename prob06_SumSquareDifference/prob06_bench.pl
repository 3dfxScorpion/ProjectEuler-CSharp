#!/usr/bin/perl

use strict;
use warnings;
use Benchmark qw(timethese cmpthese);

my $r = timethese( -1, {
    One => sub{ one() },
    Two => sub{ two() },
} );
cmpthese $r;

print "one: ", one(), "\n";
print "two: ", two(), "\n";

sub one {
    my $squares = 0;
    $squares += $_ for(1..100);
    $squares *= $squares;
    $squares -= $_**2 for(1..100);
    return $squares;
}

sub two {
    my ( $sum, $sqr ) = (0)x2;
    for (1..100) {
        $sum += $_ * $_;
        $sqr += $_;
    }
    return $sqr**2 - $sum;
}
