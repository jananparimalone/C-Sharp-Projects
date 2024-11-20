using System;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)

            //uses incrementer to count index until value is less than or equal to 5
        {
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();
        }
    }
}
