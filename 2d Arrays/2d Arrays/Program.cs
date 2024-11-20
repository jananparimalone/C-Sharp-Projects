using System;

namespace _2d_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        // the int[,] is indicating a 2d array
        {
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }

            };
            //int[,] myArray = new int[2, 3];
            //the line above this one that is commmented out would need something call manual insertion for its elements
            Console.WriteLine(numberGrid[1, 0]);



            Console.ReadLine();
        }
        // change 1 to a 0 to demonstrate within the output what this function is actually doing
    }
}
