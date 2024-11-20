// See https://aka.ms/new-console-template for more information
// Value type arguments are passed by value by default
static int Add(int x, int y)
{
    int ans = x + y;
    // Caller will not see these changes
    // as you are modifying a copy of the 
    // orignal data
    x = 10000;
    y = 88888;
    return ans;
}

Console.WriteLine("***** Fun with Methods *****\n");

// Pass two variables in by value
int x = 9, y = 10;
Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
Console.WriteLine("Answer is: {0}", Add(x, y));
Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
Console.ReadLine();

// Output parameters must be assigned by the call method
static void AddUsingOutParam(int x, int y , out int ans)
{
    ans = x + y;
}

Console.WriteLine("Demonstrating inline declaration of the out parameter...");
// No need to assign initial value to local variables
// used as output parameters provided the first time
// you use them is as output arguments
AddUsingOutParam(90, 90, out int ans);
Console.WriteLine("90 + 90 = {0}", ans);
Console.ReadLine();

// Returning multiple output parameters
Console.WriteLine("Invoking the FillTheseValues() method...");
static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}
FillTheseValues(out int i, out string str, out bool b);
Console.WriteLine("Int is: {0}", i);
Console.WriteLine("String is: {0}", str);
Console.WriteLine("Boolean is {0}", b);
Console.ReadLine();

// Discarding out params
FillTheseValues(out int a, out _, out _);
// When the last items in the method are out _ or out _ 
// They're being discard, meaning we are using the function
// but not the spaces for those last 2 params

// Reference parameters
static void SwapStrings(ref string s1, ref string s2)
{
    string tempStr = s1;
    s1 = s2;
    s2 = tempStr;
}

Console.WriteLine("Invoking the SwapStrings() method...");
string str1 = "Flip";
string str2 = "Flop";
Console.WriteLine("Before: {0}, {1} ", str1, str2);
SwapStrings(ref str1, ref str2);
Console.WriteLine("After: {0}, {1} ", str1, str2);
Console.ReadLine();

// Next we will write a method using the in modifier
static int Add2(int x, int y)
{   
    // Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
    // x = 10000;
    // y = 88888;
    int ans = x + y;
    return ans;
}

// Return average of "some number" of doubles
static double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent me {0} doubles.", values.Length);
    double sum = 0;
    if(values.Length == 0)
    {
        return sum;
    }
    for(int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}

Console.WriteLine("Invoking the CalculateAverage() method...");
// Pass in a comma-delimited list of doubles
double average;
average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
Console.WriteLine("Average of data is: {0}", average);

// Or pass an array of doubles
double[] data = { 4.0, 3.2, 5.7 };
average = CalculateAverage(data);
Console.WriteLine("Average of data is {0}", average);

// Average of 0 is 0!
Console.WriteLine("Average of data is: {0}", CalculateAverage());
Console.ReadLine();

static void EnterLogData(string message, string owner = "Programmer")
{
    // Line 117 is supposed to throw an error if null values are given
    ArgumentNullException.ThrowIfNull(message);
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}

Console.WriteLine("Invoking the EnterLogData() method...");
EnterLogData("Oh no! Grid can't find data");
EnterLogData("Oh no! I can't find the payroll data", "CFO");
// Line 126 makes the null error occur
// EnterLogData(null);
Console.ReadLine();

// Error! The default value for an optional arg must be known at compile time!
// error CS1736: Default parameter value for 'timeStamp' must be a compile-time constant
/*
static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = DateTime.Now)
{
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
    Console.WriteLine("Time of Error: {0}", timeStamp);
}
*/

// Named Arguments
static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
{
    // Store old colors to restore after message is printed.
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message.
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors.
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}

Console.WriteLine("Invoking the DisplayFancyMessage() method...");
DisplayFancyMessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);
Console.ReadLine();
// Another note about the code above is that the positional args must be listed before the named args, otherwise an error will be thrown


// This function presets the colors so that when invoking the method you don't need to include those details...
static void DisplayFancyMessage2(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
{
    // Store old colors to restore after message is printed.
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message.
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors.
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}

Console.WriteLine("Invoking the DisplayFancyMessage2() method...");
DisplayFancyMessage2(message: "Hello!");
Console.ReadLine();


