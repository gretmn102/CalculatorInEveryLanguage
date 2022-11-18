<?php

echo "PHP Simple Calculator\n";

$operators = ['+', '-', '*', '%', '/'];
$operator = readline('Enter a operator ['.implode(', ', $operators) .']: ');

if(!in_array($operator, $operators) || empty($operator)) {
  echo 'You must pick a valid operater'; exit;
}
else {

  $first = readline('Enter the First Number: ');
  if(!is_numeric($first) || empty($first)) {
    echo 'Number inputs must be numbers and not empty'; exit;
  }

  $second = readline('Enter the Second Number: ');
  if(!is_numeric($second) || empty($second)) {
    echo 'Number inputs must be numbers and not empty'; exit;
  }

  else {
    $math_string ="return (".$first . $operator . $second.");";
    $result = eval($math_string);

    echo "Result: $result";
  }
}

?>
