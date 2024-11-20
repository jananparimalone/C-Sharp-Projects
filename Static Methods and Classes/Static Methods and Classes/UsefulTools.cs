using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Methods_and_Classes
{
    //Creating a static method within our class
    //I had to change a word in line 11 to static, this means new objects can not be created in our main program
    static class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
