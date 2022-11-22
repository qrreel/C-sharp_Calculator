using System;
using System.Linq.Expressions;
using static System.Collections.Specialized.BitVector32;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Select action to be performed:");
            Console.WriteLine("Press '+' for Addition");
            Console.WriteLine("Press '-' for Subtraction");
            Console.WriteLine("Press '*' for Multiplication");
            Console.WriteLine("Press '/' for Division");
            Console.WriteLine("Press '=' for Result\n");

            Go();
        }

        static void Go()
        {
            bool isOver = false;

            Console.Write("Enter number: ");
            float result = Convert.ToInt32(Console.ReadLine());

            try
            {
                while (!isOver)
                {
                    Console.Write("Select action: ");
                    string action = Console.ReadLine();
                    if (action == "=") break;
                    Console.Write("Enter number: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    switch (action)
                    {
                        case "+": result += number; break;
                        case "-": result -= number; break;
                        case "*": result *= number; break;
                        case "/": result /= number; break;
                        default: Console.WriteLine("Unknown operation. Try again"); break;
                    }
                    Console.WriteLine($"Current result: {Convert.ToDecimal(result)}");
                }
                Console.WriteLine($"\nFinal result: {Convert.ToDecimal(result)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e.Message);
                isOver = true;
            }
        }
    }
}
