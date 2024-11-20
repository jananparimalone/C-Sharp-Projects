// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("**** Fun with Nullable Value Types *****\n");
DatabaseReader dr = new DatabaseReader();

// Get int from "database"
int? i = dr.GetIntFromDatabase();
if(i.HasValue)
{
    Console.WriteLine("Value of 'i' is: {0}", i.Value);
}
else
{
    Console.WriteLine("Value of 'i' is undefined");
}
// Get bool from "database"
bool? b = dr.GetBoolFromDatabase();
if (b!= null)
{
    Console.WriteLine("Value of 'b' is: {0}", b.Value);
}
else
{
    Console.WriteLine("Value of 'b' is undefined");
}
Console.ReadLine();
static void LocalNullableVariables()
{
    // Define some local nullable variables
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] arrayofNullableInts = new int?[10];
}

// Another way to declare a nullable variable type...
static void LocalNullableVariablesUsingNullable()
{
    // Define some local nullable types using Nullable<T>
    Nullable<int> nullableInt = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'a';
    Nullable<int>[] arrayofNullableInts = new Nullable<int>[10];
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