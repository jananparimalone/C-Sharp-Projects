using System.Text;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Diagnostics;

//The purpose of this code is to educate the user of all string data type options within C#
//Please run this code and analyze the output for each function to assess your needs and apply the appropriate changes to your code

namespace WorkingWithStringData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            StringInterpolation();
            PerformanceImprovementsForStringInterpolation();
            StringInterpolationWithDefaultInterpolatedStringHandler();
            VerbatimStrings();
            StringEquality();
            StringEqualitySpecifyingCompareRules();
            StringsAreImmutable();
            StringsAreImmutable2();
            FunWithStringBuilder();
            //TypeConversions();
            //ProcessBytes();
            UsingUncheckedKeyword();
            DeclareExplicitVars();
            DeclareImplicitNumerics();
            GetAnInt();
            ImplicitTypingIsStrongTyping();
            LinqQueryOverInts();

        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstname: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}",
                firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\" ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug ");

            //Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
            Console.WriteLine("All finished.\n\n\n ");
            Console.WriteLine();

            //Adds 4 more blank lines
            Console.WriteLine("All finished for real this time.{0}{0}{0}", Environment.NewLine);
        }

        static void StringInterpolation()
        {
            Console.WriteLine("=> String interpolation:\a");

            //Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";

            //Using curly bracket syntax
            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
            Console.WriteLine(greeting);

            //Using string interpolation
            string greeting2 = $"Hello {name} you are {age} years old.";
            Console.WriteLine(greeting2);
        }
        static void PerformanceImprovementsForStringInterpolation()
        {
            //Blow this up with ILDASM to see more performance improvements
            int age = 4;
            string name = "Soren";
            string greeting = string.Format("\tHello {0} you are {1} years old.", name.ToUpper(), age);
            Console.WriteLine(greeting);
            string greetings = $"\tHello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greetings);
            Console.WriteLine();
        }

        static void StringInterpolationWithDefaultInterpolatedStringHandler()
        {
            Console.WriteLine("=> String interpolation under the covers:\a");
            int age = 4;
            string name = "Soren";

            var builder = new DefaultInterpolatedStringHandler(3, 2);
            builder.AppendLiteral("\tHello");
            builder.AppendLiteral(name);
            builder.AppendFormatted(age);
            builder.AppendLiteral(" years old.");
            var greeting = builder.ToStringAndClear();
            Console.WriteLine(greeting);
            Console.WriteLine();
        }

        static void VerbatimStrings()
        {
            Console.WriteLine("=> Verbatim strings");
            //The following strings are printed verbatim
            //thus all escape characters will be displayed
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            //Whitespace is preserved with verbatim strings
            string myLongString = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(myLongString);
            //You can also directly insert a double quote into a literaly string by doubling the " token
            Console.WriteLine(@"Cerberus said ""Darrr! Pret-ty sun-sets""");
            //Verbatim strings can also be interpolated strings, by specifying both the interpolation operator ($) and the verbatim operator (@)
            //The order does not matter, either $@ or @$ will work
            string interp = "interpolation";
                string MyLongString2 = $@"This is a very
                    very
                        long string with {interp}";
            Console.WriteLine(MyLongString2);
        }
        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}",s1);
            Console.WriteLine("s2 = {0}",s2);
            Console.WriteLine();

            //Test these strings for equality
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 = Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 = HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 = hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        static void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("=> String equality (Case Insensitive)");
            string s1 = "Hello";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //Check the results of changing the default compare rules
            Console.WriteLine("Default rules: s1={0}, s2={1} s1.Equals(s2): {2}", s1, s2,
                s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
        }

        static void StringsAreImmutable()
        {
                Console.WriteLine("=> Immutable Strings:\a");
            //Set initial string value
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            //Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            //Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine();
        }

        static void StringsAreImmutable2()
        {
            Console.WriteLine("=> Immutable Strings 2:\a");
            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
            Console.WriteLine();
        }

        //Since strings are immutable, if you are looking for a more dynamic variable type you can use stringbuilder
        
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            sb.ToString();
            Console.WriteLine("sb variable has {0} chars.", sb.Length);
            Console.WriteLine();
            //Making a new string builder with in initial size of 256
            StringBuilder sb2 = new StringBuilder("**** Fantastic Games ****", 256);
            Console.WriteLine("sb2 variable has {0} chars.", sb2.Length);
            Console.WriteLine();
        }
        //Below is commented out because while learning typecasting you are bound to learn about overflow and underflow which throws errors that ensure the program will not run
        //under certain circumstances

/*        static void TypeConversions()
        {
            Console.WriteLine("=> Using type conversions");
            Console.WriteLine("***** Fun with type conversions *****");

            //Add two shorts and print the result
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}",
                numb1, numb2, Add(numb1, numb2));

            static int Add(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine("***** Fun with typecasting *****");
            short numb3 = 30000, numb4 = 30000;
            //Explicitly cast the int into a short (and allow loss of data)
            //Also know as typecasting
            short answer = (short)Add(numb3, numb4);
            Console.WriteLine("{0} + {1} = {2}",
                numb3, numb4, answer);
            NarrowingAttempt();
            Console.ReadLine();

            static void NarrowingAttempt()
            {
                byte myByte = 0;
                int myInt = 200;

                //Explicitly cast the int into a byte (no loss of data)
                myByte = (byte)myInt;
                Console.WriteLine("Value of myByte: {0}", myByte);
            }
        }

        //If you are looking to prevent an overflow or underflow during automatic type casting that will generate an incorrect value you can use the check keyword.
        //If you overflow or underflow the computer will display the # of bits that is over or under instead of the actual value calculated.
        //In the example below the byte value would theoretically store the # 94, because this is the overflow value. Byte variable can only store up
        //to 256. The actual mathematical result of the problem would be 350

        static void ProcessBytes()
        {
            Console.WriteLine("=> Using the checked Keyword");
            byte b1 = 100;
            byte b2 = 250;

            static int Add(int x, int y)
            {
                return x + y;
            }

            //Here is where we tell the compiler to add CIL code
            //to throw an exception if the underflow or overflow
            //takes place

            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //I have also set underflow or overflow handling within my program file for this project (WorkingWithStringData.csproj), this is 
            //helpful so you won't have to wrap numerous lines of code for error handling. The compiler 
            //will throw the error for you. The line looks like this: <CheckForOverflowUnderflow>true</CheckForOverflowUnderflow>
            //There is a way to also do this in the GUI.

*/

        static void UsingUncheckedKeyword()
        {
            Console.WriteLine("NOTE: Please edit/uncomment the code between Stringbuilder and using Unchecked to learn about checked and unchecked keywords as well as\ntypecasting, underflow, and overflow to ensure exceptions are handled to the users liking\n");
            Console.WriteLine("=> Using the unchecked Keyword");
            //Assuming /checked is enabled,
            //this block will not trigger a runtime exception
            byte b1 = 100;
            byte b2 = 250;
            unchecked
            {
                byte sum = (byte)(b1 + b2);
                Console.WriteLine("sum = {0} ", sum);
            }
        }

        static void DeclareExplicitVars()
        {
            Console.WriteLine();
            Console.WriteLine("=> Declaring explicit variable types");
            //Explicitly typed local variables
            //are declared as follows:
            //dataType variableName = initialValue;
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";

            //Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        static void DeclareImplicitNumerics()
        {
            Console.WriteLine();
            Console.WriteLine("=> Declaring implicit numerics");
            //Implicitly types numeric variable.
            var myUInt = 0u;
            var myInt = 0;
            var myLong = 0l;
            var myDouble = 0.5;
            var myFloat = 0.5F;
            var myDecimal = 0.5M;

            //Print out the underlying type
            Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
            Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
            Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
            Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
        }

        static int GetAnInt()
        {
            var retVal = 9;
            return retVal;
        }

        static void ImplicitTypingIsStrongTyping()
        {
            //The compiler knows "s" is a System.String
            var s = "This variable can only hold string data!";
            s = "This is fine...";

            //Can invoke any member of the underlying type
            string upper = s.ToUpper();

            //Error! Can't assign numerical data to a string!
            //s = 44;

            Console.WriteLine();
            Console.WriteLine("=> Implicit typing is strong typing");
            Console.WriteLine(s);
        }

        //Understanding the Usefulness of implicitly typed local variables
        //LINQ technology makes use of query expressions that can yield dynamically
        //created result sets based on the format of the query itself
        static void LinqQueryOverInts()
        {
            Console.WriteLine();
            Console.WriteLine("=> LINQ query over ints");
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //LINQ query!
            var subset = from i in numbers where i < 10 select i;

            Console.WriteLine("Values in subset: ");
            foreach (var i in subset)
            {
               Console.Write("{0} ", i);
            }

            Console.WriteLine();

            //Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }

    /*
    //Restrictions on implicitly typed variables
    class ThisWillNeverCompile
    {
        //Error! var cannot be used as field data!
        private var myInt = 10;

        //Error! var cannot be used as a return value
        //or parameter type!!
        public var MyMEthod(var x, var y) {}

        //Error! Must assign a value!
        var MyData;

        //Error! Must assign a value at exact time of declaration!
        var myInt;
        myInt = 0;

        //Error! Can't assign null as initial value!
        var myObj = null;

        //OK, if SportsCar is a reference type!
        car myCar = new SportsCar();
        myCar = null;

        //Also OK!
        var myInt = 0;
        var anotherInt = myInt;
        string myString = "Wake up!";
        var myData = myString;
    }
    */
}