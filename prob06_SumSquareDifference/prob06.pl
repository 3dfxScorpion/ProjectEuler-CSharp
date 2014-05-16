#!/usr/bin/perl

use strict;
use warnings;

my ( $sum, $sqr ) = (0)x2;
for (1..100) {
    $sum += $_ * $_;
    $sqr += $_;
}
print $sqr**2 - $sum, "\n";
