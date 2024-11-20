using System;

namespace ConsoleMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //prints the text and jumps to a new line

            Console.Write("Yo "); //prints the text in the same line

            Console.WriteLine("ur mom is gey");

            //below is the read line method

            Console.WriteLine("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0} ",readInput );

            //below is the read key method

            Console.Write("Enter a string and press enter, I will evaluate its ASCII value: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value of entered string is {0}", asciiValue);

            Console.ReadKey(); //nothing would print without this statement
        }
    }
}
