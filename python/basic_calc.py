# Written by ezweber#4540
# 4-11-2022

try:
    num1 = int(input("Enter your first number: "))
    num2 = int(input("Enter your second number: "))
except ValueError:
    print("Make sure to enter a int.")

operation = input("Enter \"+\", \"-\", \"*\", \"/\", or \"%\": ")

match operation:
    case "+":
        print(num1 + num2)
    case "-":
        print(num1 - num2)
    case "*":
        print(num1 * num2)
    case "/":
        print(num1 / num2)
    case "%":
        print(num1 % num2)
    case other:
        print("Please enter a valid operator.")