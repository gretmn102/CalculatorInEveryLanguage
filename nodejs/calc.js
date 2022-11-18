const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

let operators = ['+', '-', '*', '/'];

function usrInput(message) {
  return new Promise((resolve, reject) => {
    rl.question(message, (answer) => {
      resolve(answer);
    });
  });
}

console.log("NodeJS Simple Calculator")

async function startCalcPrompt() {
    var first = await usrInput(`Enter first number: `);

    if (!Number.parseFloat(first) || !first) {
        console.log(`You must enter a number`);
        process.exit(0);
      }

    var second = await usrInput(`Enter second number: `);

    if (!Number.parseFloat(second) || !second) {
        console.log(`You must enter a number`);
        process.exit(0);
      }

    var operator = await usrInput(`Enter operator [${operators.join(", ")}]: `);

    if (!operators.includes(operator) || !operator) {
    console.log(`The available operators are: ${operators.join(", ")}`);
    process.exit(0);
    }

    const calc = s => Function(`return(${s})`)();
    const result = calc(first+operator+second);

    console.log(result);
  rl.close();
}

startCalcPrompt()
