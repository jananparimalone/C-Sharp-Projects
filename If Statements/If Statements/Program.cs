using System;

namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //This program will take the boolean input values below and then print statements based on them
        //This unit reviews conditional statements (if,else;else.if;etc.) 
        //Notice the use of the && symbol, this indicates that either ONE or BOTH conditions are not met

            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are not a tall male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            {
                Console.WriteLine("You are not tall or a male");
            }
            Console.ReadLine();
        }

        
    }
}
