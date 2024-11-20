using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)

        //The first part of this code was written in the unit for classes and objects
        //In the second part of writing this code, I initialized variables in the constructor style, I made edits to both project files to do this
        {
            Book book1 = new Book("The Story Of Ur Mom", "Ur Mom", 400);

            //we can also create multiple object instances (ex. of second object creation below)

            Book book2 = new Book("The Continuation Of The Story Of Ur Mom", "Ur Mom", 69);

            //example of value modification with constructor style initialization below

            book2.title = "A New Title";

            //You can also add multiple constructors to the Book.CS file to use in your program files, if needed (ex. below)

            Book book3 = new Book();

            //If I had a whole library I could make multiple books with attributes , this is how a database is made

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
