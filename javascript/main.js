var num1 = parseInt(prompt("Input your first number: "));
var num2 = parseInt(prompt("Input your second number: "));
var op = prompt("Input your desired operation: ");

if (op == "+") {
  var total = num1 + num2
  console.log(total);
}

if (op == "-") {
  var total = num1 - num2
  console.log(total);
}

if (op == "*") {
  var total = num1 * num2
  console.log(total);
}

if (op == "/") {
  var total = num1 / num2
  console.log(total);
}
