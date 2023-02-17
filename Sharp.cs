using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;

            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operator (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
