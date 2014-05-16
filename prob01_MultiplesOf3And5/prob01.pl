#!/usr/bin/perl

use strict;
use warnings;
use Benchmark qw( timethese cmpthese );

my $sumItr = itr(999);
my $sumRec = rec(999);
print "sum: $sumItr\n";
print "sum: $sumRec\n";

my $r = timethese( -1, {
    sumItr => sub{ itr(999) },
    sumRec => sub{ rec(999) },
} );
cmpthese $r;

sub itr {
    my $sum = 0;
    for ( 0 .. shift ) {
        $sum += $_ unless ( $_ % 3 && $_ % 5 )
    }
    return $sum;
}
sub rec {
    no warnings "recursion";
    return 0 if $_[0] < 3;
    return $_[0] + rec( $_[0] - 1 ) unless $_[0] % 3;
    return $_[0] + rec( $_[0] - 1 ) unless $_[0] % 5;
    return rec( $_[0] - 1 );
}
