import java.util.Scanner;

class Main {
    public static void main(String[] args) {

        char operator;
        Double firstNum, secondNum, result;

        Scanner input = new Scanner(System.in);

        System.out.println("Choose an operator: ( + ) ( - ) ( * ) ( / )   ");
        operator = input.next().charAt(0);

        System.out.print("Input your first Number: ");
        firstNum = input.nextDouble();
        System.out.print(System.lineSeparator());

        System.out.print("Input your second number: ");
        secondNum = input.nextDouble();
        System.out.print(System.lineSeparator());

        switch (operator) {

            case '+':
                result = firstNum + secondNum;
                System.out.println(firstNum + " + " + secondNum + " = " + result);
                break;
            case '-':
                result = firstNum - secondNum;
                System.out.println(firstNum + " - " + secondNum + " = " + result);
                break;
            case '*':
                result = firstNum * secondNum;
                System.out.println(firstNum + " * " + secondNum + " = " + result);
                break;
            case '/':
                result = firstNum / secondNum;
                System.out.println(firstNum + " / " + secondNum + " = " + result);
                break;

            default:
                System.out.println("an Invalid Operator was provided!");
                break;
        }

        input.close();
    }
}
