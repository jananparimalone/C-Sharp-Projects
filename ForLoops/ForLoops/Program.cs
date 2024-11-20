using System;

namespace ForLoops
{
    internal class Program
    {
       //PRO TIP: a for loop is generally used when you know exactly how many times you want to loop through a block of code, 
       //user could use this instead of a while loop, which will just keep looping
       //we use the .Length to tell us HOW MANY ELEMENTS are inside the array
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                Console.WriteLine(luckyNumbers[i]);
                }

        }
    }
}
