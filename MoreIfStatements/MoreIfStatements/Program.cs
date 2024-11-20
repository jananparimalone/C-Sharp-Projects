using System;

namespace MoreIfStatements
{
    internal class Program
    {
        static void Main(string[] args)

        //This method will take three parameters of input and compare them to get the maximum value
        {
            Console.WriteLine(GetMax(20, 10, 4));
            Console.ReadLine();
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 > num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            
            return result;
            
        }
    }
}
