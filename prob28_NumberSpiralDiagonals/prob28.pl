#!/usr/bin/perl 

use strict;
use warnings;
use feature qw(state);

state $CENTER = 1;

my $array = 1001;
my $range = $array / 2;
# sum 1 + corner values by looping through
my $tot = 1;
for my $r ( 2..$range + $CENTER ) {
    $tot += 4 * ( $r**2 ) - 10 * $r + 7;    # 3, 13, 31...
    $tot += 4 * ( $r**2 ) -  8 * $r + 5;    # 5, 17, 37...
    $tot += 4 * ( $r**2 ) -  6 * $r + 3;    # 7, 21, 43...
    $tot += 4 * ( $r**2 ) -  4 * $r + 1;    # 9, 25, 49...
}
print "total: ", $tot, "\n";

