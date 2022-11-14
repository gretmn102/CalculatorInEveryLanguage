using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your desired operation [+, -, *, /]");
            string op = Console.ReadLine();  

            if (op == "+") { 
                Console.WriteLine(firstNum + secondNum);
                Console.ReadKey();
            }

            else if (op == "-") {
                Console.WriteLine(firstNum - secondNum);
                Console.ReadKey();
            }

            else if (op == "*")
            {
                Console.WriteLine(firstNum * secondNum);
                Console.ReadKey();
            }

            else if (op == "/")
            {
                Console.WriteLine(firstNum / secondNum);
                Console.ReadKey();
            }


            
        }
    }
}
