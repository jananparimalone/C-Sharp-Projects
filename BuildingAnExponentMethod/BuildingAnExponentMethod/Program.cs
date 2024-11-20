using System;

namespace BuildingAnExponentMethod
{
    internal class Program

        //this is the part of the statement that prints out my code (ex.GetPow(3,2)), this is our function. We are passing it arguments baseNum = 3 or powNum = 2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            //the following for loops will keep looping until the incrementer counts to the value of PowNum based on the condition of this statement
            //everytime we go through the for loop we multiple the result by the base num

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            //then its gonna spit out my result, which in this scenario happens to be 9 because it was originally 1
            //but we multiplied it by basenum 3 when we passed the function that particular argument

            return result;
        }
    }
}
