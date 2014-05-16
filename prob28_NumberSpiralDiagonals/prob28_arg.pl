#!/usr/bin/perl 

use strict;
use warnings;
use feature qw(state);

state $CENTER = 1;

my $array = shift || 1001;
my $range = $array / 2;
# sum 1 + corner values by looping through
my ( $sum, $tot ) = (1) x 2;
for my $i ( $CENTER..$range ) {
    for ( 1..4 ) {
        $sum += 2 * $i; 
        $tot += $sum;
    }
}
print "total from loops: $tot\n";
# sum 1 + each diagonal from center
$tot = 1;
for my $r ( 2..$range + $CENTER ) {
    $tot += 4 * ( $r**2 ) - 10 * $r + 7;    # 3, 13, 31...
    $tot += 4 * ( $r**2 ) -  8 * $r + 5;    # 5, 17, 37...
    $tot += 4 * ( $r**2 ) -  6 * $r + 3;    # 7, 21, 43...
    $tot += 4 * ( $r**2 ) -  4 * $r + 1;    # 9, 25, 49...
}
print "total from diags: $tot\n";

