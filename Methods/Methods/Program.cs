using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Pari", 24);
            Console.ReadLine();
        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }

}
