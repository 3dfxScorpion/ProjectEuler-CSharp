#!/usr/bin/perl 

use strict;
use warnings;

my $range = shift|| 999999;

my $max = 0;
my @cache;
my @sol;
for my $n (1..$range) {
    my $count = 1;
    my $num = $n;
    until ( $num == 1 ) {
        $count += $cache[$num] and last if defined $cache[$num];
        $num = ( $num % 2 ) ? 3 * $num + 1 : $num / 2;
        ++$count;
    }
	$cache[$n] = $count;
    if ( $count > $max ) {
        $max = $count;
        @sol = ("max: $max, num: $n");
    }
}
print "@sol\n";
