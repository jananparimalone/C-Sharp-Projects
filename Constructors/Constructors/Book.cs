using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Book
        //below is an example of how to store attributes to a class
        //these are called class attributes 
    {
        public string title;
        public string author;
        public int pages;

        //Constructor initialization
        public Book()
        {

        }

        //This is the constructor, it is aspecial method inside the class that gets called when an object within the class is created
        //When it is being passed this way, a name parameter is required in the program file to be passed to the constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
