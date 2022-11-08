import strutils

echo "Enter your first number:"
var num1 = readLine(stdin)  # Get user input

var num1_int = parseInt(num1)   # Convert input to an integer

echo "Enter your second number:"
var num2 = readLine(stdin)

var num2_int = parseInt(num2)

echo "Enter the operation you want to preform (+, -, /, *):"
var operation = readLine(stdin)

case operation:
    of "+":
        echo(num1_int+num2_int)
    of "-":
        echo(num1_int-num2_int)
    of "/":
        echo(num1_int/num2_int)
    of "*":
        echo(num1_int*num2_int)
    else:
        echo("Enter a valid operation (+, -, /, *)")