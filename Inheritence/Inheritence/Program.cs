using System;

//Inheritence is when one class inherits all the functionality of another class 

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of the chef class & telling it to make chicken
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            //below Italian chef is overiding an iheritence from its super class ( the class above subclass italian chef ), that is why the special dishes are different in the output

            ItalianChef Italian_Chef = new ItalianChef();
            Italian_Chef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
