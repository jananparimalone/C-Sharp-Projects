using System;

namespace Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //G, PG, PG-13, R, NR
            //because rating is a private class in our class file we can not presently access it
            //it was changed to Rating with a capital R so we could access it through our getter and setter
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
