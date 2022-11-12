using System;
using static System.Collections.Specialized.BitVector32;

namespace Calculator
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Select action to be performed:");
            Console.WriteLine("Press '+' for Addition");
            Console.WriteLine("Press '-' for Subtraction");
            Console.WriteLine("Press '*' for Multiplication");
            Console.WriteLine("Press '/' for Division");
            Console.WriteLine("Press '=' for Result\n");

            Console.Write("Enter number: ");
            float result = Convert.ToInt32(Console.ReadLine());

            NewAction(result);
        }

        public static float Actions(float result, float num, string action)
        {
            if (action == "+")
            {
                result += num;
                CurrentResult(result);
            }
            else if (action == "-")
            {
                result -= num;
                CurrentResult(result);
            }
            else if (action == "*")
            {
                result *= num;
                CurrentResult(result);
            }
            else if (action == "/")
            {
                if (num != 0)
                {
                    result /= num;
                    CurrentResult(result);
                }
                else
                {
                    Console.WriteLine("Go back to school...");
                }
            }
            else if (action == "=")
            {
                Console.WriteLine("\nFinal result: " + result);
            }
            else
            {
                Console.WriteLine("Wrong action! You're out!");
            }

            return result;
        }

        public static void NewAction(float result)
        {
            Console.Write("Select action: ");
            string action = Console.ReadLine();

            if (action != "=")
            {
                Console.Write("Enter number: ");
                float num = Convert.ToInt32(Console.ReadLine());
                Actions(result, num, action);
            }
            else
            {
                Actions(result, 0, action);
            }

        }

        private static void CurrentResult(float result)
        {
            Console.WriteLine("Current result: " + result);
            NewAction(result);
        }
    }
}