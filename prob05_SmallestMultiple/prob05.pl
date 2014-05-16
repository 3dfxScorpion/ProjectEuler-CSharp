#!/usr/bin/perl

use strict;
use warnings;

my $s = 2520;
while ( $s < 500000000 ) {
    print $s,"\n" and exit unless grep $s % $_, (1..20);    
    $s += 2520;
}
