using System;

namespace Switch_Statements
{
    internal class Program
    {

        //I made my code extra fancy so it takes input from the user, but this is the method that prints the result in any case
        static void Main(string[] args)
        {
            string userinput;
            Console.Write("Enter a number between 1-7: ");
            userinput = Console.ReadLine();

            Console.Write(GetDay(0));

            Console.ReadLine();

        }

        //Method using the switch statement
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)

            {
                case 0: 
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;

            }

            return dayName;
            
         }
    }
}
