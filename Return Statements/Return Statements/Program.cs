using System;
using System.Net.NetworkInformation;

namespace Return_Statements
{
    internal class Program
    {
        //creating a method where one parameter is required and it performs the operations
        //on the number within the first method and then prints the output, more mathematical
        //operations could be encorporated 
        static void Main(string[] args)
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();
        }
        static int cube(int num)

        {
            int result = num * num * num;
            return result;
        }
    }
}
