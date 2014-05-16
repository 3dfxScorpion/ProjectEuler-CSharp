#!/usr/bin/perl

use strict;
use warnings;
use Data::Dump qw{dump};

my @sm_tri = (
                         [75],
                       [95, 64],
                     [17, 47, 82],
                   [18, 35, 87, 10],
                  [20, 4, 82, 47, 65],
                 [19, 1, 23, 75, 3, 34],
               [88, 2, 77, 73, 7, 63, 67],
             [99, 65, 4, 28, 6, 16, 70, 92],
          [41, 41, 26, 56, 83, 40, 80, 70, 33],
        [41, 48, 72, 33, 47, 32, 37, 16, 94, 29],
      [53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14],
    [70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57],
  [91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48],
 [63, 66, 4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31],
[4, 62, 98, 27, 23, 9, 70, 98, 73, 93, 38, 53, 60, 4, 23],
);
my @sol_tri = @sm_tri;

# Find the sum of adjacent diagonal

my ($idx, $sum) = (0)x2;
my $s = $sm_tri[0][0];      # start sum with top element, duh!
for my $row (@sm_tri) {
    next if ( scalar(@$row) == 1 );
    if ( @$row[$idx] > @$row[$idx + 1] ) {
        $s += @$row[$idx];
    } else {
        $s += @$row[$idx + 1];
        $idx++;
    }
    $sum += $s;
    $s = 0;
}
print "\nsum: $sum\n";
dump(@sm_tri);

$idx = undef;
for my $row (reverse(@sm_tri)) {
    my ($i, $max) = (0)x2;
    for my $e (@$row) {
        ($max, $idx) = ( $e > $max ) ? ($e, $i) : ($max, $idx);
        $i++;
    }
    print "@$row\n";
    print "max: $max, idx: $idx\n";
}

for ( my $i = $#sm_tri - 1; $i >= 0; $i-- ) {
    for my $j (0 .. $#{$sm_tri[$i]}) {
        $a = $sm_tri[$i][$j] + $sm_tri[$i + 1][$j];
        $b = $sm_tri[$i][$j] + $sm_tri[$i + 1][$j + 1];
        $sm_tri[$i][$j] = ( $a > $b ) ? $a : $b;
    }
}

dump(@sm_tri);
print $sm_tri[0][0], "\n";
