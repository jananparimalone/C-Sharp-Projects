namespace WorkingWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            PassAndRecieveArrays();
            SystemArrayFunctionality();
            SystemArrayFunctionalityIndicesAndRanges();
            Console.WriteLine();
            Console.WriteLine("Select enter to end the program...");
            Console.ReadLine();
        }

        //Example of simple array declaration
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation");
            //Create and fill an array of 3 integers
            int[] myInts = new int[3];
            //Fill the elements by index
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            //Now we will print each value
            foreach(int i in myInts)
            {
                Console.WriteLine(i);
            }
            //Create a 100 item string array, indexed 0 - 99
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        //Example of array initialization

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization");

            //Array initialization syntax using new keyword
            string[] stringArray = new string[]
                {"one", "two", "three"};
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            //Array initialization syntax without using the new keyword
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //Array initialization syntax with new keyword and size
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);

            //This code will never run, it will give a syntax error
            //OOPS! Mismatch of size and elements
            //int[] intArray = new int[2] { 20, 22, 23, 0 };
            Console.WriteLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization");

            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is b: {0}", b.ToString());

            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is c: {0}", c.ToString());

            // Error! Mixed Types!
            // var d = new[] { 1, "one", 2, "two", false };
            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in the array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];
            // Populate (3*4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            // Print (3*4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create a jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }
            // Print each row (remember, each element is defaulted to zero!).
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < myJagArray[i].Length; j++)
                {
                Console.Write(myJagArray[i][j] + " ");
                }
            Console.WriteLine();
            }
        }

        static void PrintArray(int[] myInts)
        {
            for(int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndRecieveArrays()
        {
            Console.WriteLine();
            Console.WriteLine("=> Arrays as params and return values");
            // Pass array as parameter
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as return value
            string[] strs = GetStringArray();
            foreach(string s in strs)
            {
                Console.WriteLine(s);
            }
        }
        static void SystemArrayFunctionality()
        {
            Console.WriteLine();
            Console.WriteLine("=> Working with System.Array");
            // Initialize items at startup
            string[] gothicBands = { "Tone on Tail", "Bauhaus", "Sisters of Mercy" };

            // Print out names in declared order
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.WriteLine(gothicBands[i] + ", ");
            }
            //Console.WriteLine("\n");
            // Reverse them...
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");

            // ...and print them
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.WriteLine(gothicBands[i] + ", ");
            }
            //Console.WriteLine("\n");
            // Clear all out but the first member
            Array.Clear(gothicBands, 1, 2);
            Console.WriteLine("-> Cleared out all but one...");

            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }

        static void SystemArrayFunctionalityIndicesAndRanges()
        {
            Console.WriteLine();
            Console.WriteLine("=> Working with System.Array with indexing and ranges");
            // Initialize items at startup
            string[] gothicBands = { "Tone on Tail", "Bauhaus", "Sisters of Mercy" };

            // Print out names in declared order
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Index idx = i;
                // Print a name
                Console.WriteLine(gothicBands[idx] + ", ");
            }
            //Console.WriteLine("\n");
            // Reverse them...
            Console.WriteLine("-> The reversed array");

            // ...and print them
            for (int i = 1; i <= gothicBands.Length; i++)
            {
                Index idx = ^i;
                // Print a name
                Console.WriteLine(gothicBands[idx] + ", ");
            }
            //Console.WriteLine("\n");
            // Clear all out but the first member
            Console.WriteLine("-> Cleared out all but one...");

            foreach (var itm in gothicBands[0..1])
            {
                // Print a name
                Console.WriteLine(itm + ", ");
            }
            //Console.WriteLine("\n");
            Console.WriteLine("-> Cleared out all but one using the range data type for the range...");
            // Or you can pass the range to a sequence using the new range data type
            Range r = 0..1; // The end of the range is exclusive
            foreach (var itm in gothicBands[r])
            {
                // Print a name
                Console.WriteLine(itm + ", ");
            }
            //Console.WriteLine("\n");
            Console.WriteLine("-> Cleared out all but one using index variables and range data type...");
            // The same result will occur from the following code
            Index idx1 = 0;
            Index idx2 = 1;
            Range r2 = idx1..idx2; // the end of the range is exclusive
            foreach (var itm in gothicBands[r2])
            {
                // Print a name
                Console.WriteLine(itm + ", ");
            }
            //Console.WriteLine("\n");
            // The ranges below represent the same subset
            // gothicBands[..]
            // gothicBands[0..^0]
            // gothicBands[0..3]
            // This code gets the 2nd to last band from the list
            Console.WriteLine("-> Lastly, selecting middle band using ElementAt() function...");
            // Retrieves the element from the array at the specified location
            var band = gothicBands.ElementAt(^2);
            Console.WriteLine(band);
        }
    }
}