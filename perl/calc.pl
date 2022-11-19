 #!/usr/bin/perl

use strict;
use autodie;
use warnings FATAL => "all";
use experimental 'switch';

print "Perl Simple Calculator\n";

print "Enter the first number: ";
my $first = <>;
$first = $first*1;

if ((!$first =~/^-?\d*\.\d+$/) || !$first) {
print("You need to enter a number!");
exit;
}

print "Enter the second number: ";
my $second = <>;
$second = $second*1;
if ((!$second =~/^-?\d*\.\d+$/) || !$second) {
print("You need to enter a number!");
exit;
}

print "Enter a operator: ";
chomp( my $operator = <> );

given ($operator) {
    when ('+') { print $first+$second ;}
    when ('-') { print $first-$second ;}
    when ('*') { print $first*$second ;}
    when ('/') { print $first/$second ;}
    default { print 'Operators: +, -, *, /';}
}
