#!/usr/bin/perl 

use strict;
use warnings;

my $max = 0;
my @sol;
for my $n (1..999999) {
    my $count = 1;
    my $num = $n;
    until ( $num == 1 ) {
        $num = ( $num % 2 ) ? 3 * $num + 1 : $num / 2;
        ++$count;
    }
    if ( $count > $max ) {
        $max = $count;
        @sol = ("max: $max, num: $n\n");
    }
}
    print "@sol\n";
