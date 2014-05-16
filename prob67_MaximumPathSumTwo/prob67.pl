#!/usr/bin/perl

# euler prob67

use strict;
use warnings;
use Data::Dump qw{dump};

# Read in file into array of row strings
my @file_array;
open(my $fh, "<", "triangle.txt") or die "Didn't happen...\n"; 
while ( <$fh> ) {
    $file_array[$.-1] = $_;
}
close($fh);
# strip off all leading zeros
my @lg_tri;
for my $row (@file_array) {
    my @new_row = grep { s/^0// || $_ } split( / /, $row);
    push @lg_tri, \@new_row;
}
# calculate and generate solution triangle
my @soln = ("*");
my ($idx, $sum) = (0)x2;
my $s = $lg_tri[0][0];      # start sum with top element, duh!
for my $row (@lg_tri) {
    next if ( scalar(@$row) == 1 );
    my @dash = ("-") x scalar(@$row);
    if ( @$row[$idx] > @$row[$idx + 1] ) {
        $s += @$row[$idx];
        $dash[$idx] = "*";
    } else {
        $s += @$row[$idx + 1];
        $dash[$idx + 1] = "*";
        $idx++;
    }
    $sum += $s;
    $s = 0;
    push @soln, grep { s/ //g || $_ } "@dash";
}
# show solution triangle and sum
dump(@soln);
print "\nsum: $sum\n";

for ( my $i = $#lg_tri - 1; $i >= 0; $i--) {
        for my $j ( 0 .. $#{$lg_tri[$i]} ) {
                $a = $lg_tri[$i][$j] + $lg_tri[$i+1][$j];
                $b = $lg_tri[$i][$j] + $lg_tri[$i+1][$j+1];
                if ( $a > $b ) { $lg_tri[$i][$j] = $a; }
                else { $lg_tri[$i][$j] = $b; }
        }
}
print "$lg_tri[0][0]\n";

