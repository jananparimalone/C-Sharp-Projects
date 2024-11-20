using System;

namespace BuildingABetterCalculator
{
    internal class Program

    {
        static void Main(string[] args)

        //ask user for input

        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //check what value is equal to depending on operations performed using comparison operators 

            if (op == "+")
            {
                Console.Write(num1 + num2);
            } else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);

            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            {
                Console.ReadLine();
            }
        }
    }
}
