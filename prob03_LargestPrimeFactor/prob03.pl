#!/usr/bin/perl

use strict;
use warnings;

my $num = 600851475143;
my $limit = int( sqrt($num) );
# lets start x as an odd number
while ( $limit > 2 ) {
    print $limit, "\n" and exit
        if chkPrime($limit) && ( $num % $limit == 0 );
    --$limit;
}

sub chkPrime {
    my $dvdnd = shift;
    return 0 if ( $dvdnd == 1 ) || ( $dvdnd % 2 == 0 );
    return 1 if ( $dvdnd == 2 ) || ( $dvdnd <= 7 );
    my $sqrtdnd = int( sqrt($dvdnd) );
    my $i = 3;
    while ( $i <= $sqrtdnd ) {
        return 0 if ( $dvdnd % $i == 0 );
        $i += 2;
    }
    return 1;
}

