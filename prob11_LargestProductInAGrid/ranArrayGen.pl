#!/usr/bin/perl 

use strict;
use warnings;

my $i = shift || 20;
for (1..$i) {
    print join( " ",
        map { my $n = int( 100*rand() );
            ( $n < 10 ) ? "0" . $n : $n;
        } (1..$i)
    ), "\n";
}

