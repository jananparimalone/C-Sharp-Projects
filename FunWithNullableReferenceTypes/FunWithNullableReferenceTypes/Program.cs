// Warning CS8600 converting null literal or possible null value to non-nullable type
// TestClass myNonNullableClass = myNullableClass;
#nullable disable
TestClass anotherNullableClass = null;
// Warning CS8632 the annotation for nullable reference types
// should only be used in code within a '#nullable' annotations
TestClass? badDefinition = null;
// Warning CS8632 the annotation for nullable reference types
// should only be used in code within a '#nullable' annotations
string? anotherNullableString = null;
#nullable restore
Console.WriteLine("***** Fun with Nullable Value Types *****\n");
DatabaseReader dr = new DatabaseReader();

// If the value from GetIntFromDatabase() is null,
// assign local variable to 100
int myData = dr.GetIntFromDatabase() ?? 100;
Console.WriteLine("Value of myData: {0}", myData);
Console.ReadLine();

Console.WriteLine("***** Demonstrating longhand notation *****\n");
// Longhand notation using ?? syntax
int? moreData = dr.GetIntFromDatabase();
if (!moreData.HasValue)
{
    moreData = 100;
}
Console.WriteLine("Value of moreData: {0}", moreData);
Console.ReadLine();

// Examples of null-coalescing assignment operator
Console.Write("***** Null-coalescing operator *****\n");
int? nullableInt = null;
nullableInt ??= 12;
nullableInt ??= 14;
Console.WriteLine(nullableInt);
Console.ReadLine();

Console.Write("***** Example of nullable reference types *****\n");

// Not sure why I had to comment out line below, it kept giving me an error
// EnterLogData(null);
// Warning CS8625 Cannot convert null literal to non-nullable reference type
string? msg = null;
EnterLogData(msg);
// Warning CS8604 Possible null reference argument for parameter 'message' in
// 'void EnterLogData(string message, string owner = "Programmer")'
Console.ReadLine();

Console.Write("***** Performing checks on incoming parameters (incoming to my method) *****\n");
string[] nullarray = { };
TesterMethod(nullarray);
Console.ReadLine();

// Now I will write a method to perform a check on incoming parameters
static void TesterMethod(string[] args)
{
    // We should check for null before accessing array data
    if (args != null)
    {
        Console.WriteLine($"You sent me {args.Length} arguments.");
        // You could also use the null coalescing operator to assign a default value with line 59
        // Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
    }
}
static void EnterLogData(string message, string owner = "Programmer")
{
    // Not really sure why I had to comment out the line below. It kept giving me an error because message var was null?
    // ArgumentNullException.ThrowIfNull(message);
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}
public class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }

    string? nullableString = null;
    TestClass? myNullableClass = null;

}
class DatabaseReader
{
    // Nullable data field
    public int? numericValue = null;
    public bool? boolValue = true;

    // Note the nullable return type
    public int? GetIntFromDatabase()
    { return numericValue; }

    // Note the nullable return type
    public bool? GetBoolFromDatabase()
    { return boolValue; }
}

// If you wanted to treat all of the nullable reference types as errors
// or even just a few of them you could add these statements into the .csproj file
// within the <PropertyGroup> section ending with the statment </PropertyGroup>
// <WarningsAsErrors>CS8605,CS8625</WarningsAsErrors>
// <WarningsAsErrors> Nullable </WarningsAsErrors>
// If you want to just consider every warning an error you could use
// <TreatWarningsAsErrors>true</TreatWarningsAsErrors>