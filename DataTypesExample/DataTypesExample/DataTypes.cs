using System;

namespace DataTypesExample
{
    internal class DataTypes
    {
        static void Main(string[] args)

        {   //declaring multiple variables at once
            int num3, num4, num5;

            //declaring a variable
            int num1;

            //assign a value to variable
            num1 = 13;

            // declaring and initializing a variable in one go
            int num2 = 23;
            long myLongNum = 18123098710270981;
            num2 = 100;
            int sum = num1 + num2;

            //using concatination
            Console.WriteLine("num is " + num1);
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDib = d1 / num1;
            int dIDivInt = (int)d1 / num1;
            Console.WriteLine("d1 / num1 is " + dIDib);
            Console.Read();
        }
    }
}


