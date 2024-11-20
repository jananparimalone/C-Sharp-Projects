namespace WorkingWithIterationConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            IfElseExample();

            //A basic for loop, this for loop will iterate over the loop for the fixed value of 4 iterations
            static void ForLoopExample()
            {
                Console.WriteLine();
                Console.WriteLine("=> For loop example");
                //Note "i" is only visible within the scope of the for loop 
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Number is: {0} ", i);
                }
                //"i" is not visible here
            }

            //Iterate array items using foreach
            static void ForEachLoopExample()
            {
                Console.WriteLine();
                Console.WriteLine("=> Foreach loop example");
                string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
                foreach (string c in carTypes)
                {
                    Console.WriteLine(c);
                }

                int[] MyInts = { 10, 20, 30, 40 };
                foreach (int i in MyInts)
                {
                    Console.WriteLine(i);
                }
            }

            //This function uses a LINQ Query to iterate over the set using implicit typing
            static void LinqQueryOverInts()
            {
                Console.WriteLine();
                Console.WriteLine("=> Implicit typing with foreach example");
                int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

                //LINQ query!
                var subset = from i in numbers where i < 10 select i;
                Console.Write("Values in subset: ");

                foreach (var i in subset)
                {
                    Console.Write("{0} ", i);
                }
            }

            //Now onto the while loop...
            static void WhileLoopExample()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=> While loop example");

                string userIsDone = "";

                //Test on a lower-class copy of the string
                while(userIsDone.ToLower() != "yes")
                {
                    Console.WriteLine("In while loop");
                    Console.Write("Are you done? [yes] [no]: ");
                    userIsDone = Console.ReadLine();
                }
            }

            //And the dowhile loop...
            static void DoWhileLoopExample()
            {
                Console.WriteLine();
                Console.WriteLine("=> Do/while loop example");
                string userIsDone = "";

                do
                {
                    Console.WriteLine("In do/while loop");
                    Console.Write("Are you done? [yes] [no]: ");
                    userIsDone = Console.ReadLine();
                } while (userIsDone.ToLower() != "yes"); //Note the semicolon!
            }

            //If else example...
            static void IfElseExample()
            {
                Console.WriteLine();
                Console.WriteLine("=> Ifelse example");
                string stringData = "My textual data";
                Console.WriteLine("my string = " + stringData);
                if (stringData.Length > 0)
                {
                    Console.WriteLine("string is greater than 0 characters");
                }
                else
                {
                    Console.WriteLine("string is not greater than 0 characters");
                }
                Console.WriteLine();
            }
        }
    }
}