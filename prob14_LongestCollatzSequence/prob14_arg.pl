#!/usr/bin/perl 

use strict;
use warnings;

my $range = shift || 100;

my $max = 0;
my @array;
my @sol;
for my $n (1..$range) {
    my $count = 1;
    my @temp = ($n);
    my $num = $n;
    until ( $num == 1 ) {
        $num = ( $num % 2 ) ? 3 * $num + 1 : $num / 2;
        push @temp, $num;
        ++$count;
    }
#    print "@temp\n";
    if ( $count > $max ) {
        $max = $count;
        @sol = ("max: $max, num: $n\n"); #, @temp);
    }
}
    print "@sol\n";
