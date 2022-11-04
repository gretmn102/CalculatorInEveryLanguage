using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Input your first number");
    int firstNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Input your second number");
    int secondNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(firstNum + secondNum);

    Console.ReadKey();
  }
}
