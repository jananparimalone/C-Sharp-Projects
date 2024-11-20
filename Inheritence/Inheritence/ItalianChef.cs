using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    // The portion of this class decleration that says : Chef is my inheritence, this indicated the Italian Chef can make all the same recipes as the Chef
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        //below we are telling C# to override the MakeSpecialDish method 
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

    }
}
