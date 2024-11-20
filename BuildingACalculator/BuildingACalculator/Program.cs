using System;
using System.Transactions;

namespace BuildingACalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter another number: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1+num2);
            Console.ReadLine();
        }
    }
}
