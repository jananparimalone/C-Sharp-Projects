using System;

namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)

            // now we have created our class we will create objects an object is an instance of a class.
            // Class is essentially going to specify what objects will be needed to make up the class.
            // book is now considered a data type in our program, so it can be used in this way:
        {
            Book book1 = new Book();
            book1.title = "The Story Of Ur Mom";
            book1.author = "Ur mom";
            book1.pages = 757;

            // we can also create multiple object instances

            Book book2 = new Book();
            book1.title = "The Continuation Of The Story Of Ur Mom";
            book1.author = "Ur mom";
            book1.pages = 69;

            // if I had a whole library I could make multiple books with attributes , this is how a database is made

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
