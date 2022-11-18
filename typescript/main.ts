const x = prompt("Input your first number: ");
const y = prompt("Input your second number: ");
const op = prompt("Input your desired operation: ");

if (x === null || y === null || op === null) throw new Error;

const num1 = parseFloat(x);
const num2 = parseFloat(y);

if (op === "+") console.log(num1+num2);
if (op === "-") console.log(num1-num2);
if (op === "/") console.log(num1/num2);
if (op === "*") console.log(num1*num2);