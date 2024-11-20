using System;

namespace String
{
    class String
    {
        static void Main(string[] args)
        {
            string myname = "Pari";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowercaseMessage = message.ToLower();

            Console.WriteLine(lowercaseMessage);
            Console.Read();
        }
    }
}
