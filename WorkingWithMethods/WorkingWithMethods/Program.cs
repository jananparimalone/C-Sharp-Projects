// See https://aka.ms/new-console-template for more information
// Recall that static methods can be called directly
// without creating a class instance
// static returnType MethodName(parameter list) { /* Implementation */ }

// Fun with local functions
using System.Diagnostics.CodeAnalysis;

//static int Add(int x, int y)
//{
    //return x + y;
//}

// Another way you could write this method would be
// static int Add(int x, int y) => x + y
// There would be no difference in the IL for these codes
// Fun fact... => is a lambda operation

// Let's rewrite this as a local function...
//static int AddWrapper(int x, int y)
//{
    // Do some validation here
    //return Add();

    //int Add()
    //{
        //return x + y;
    //}
//}

// This method below is a local function with attributes added to it
/*
#nullable enable
private static void Process(string?[] lines, string mark)
{
    foreach (var line in lines)
    {
        if (IsValid(line))
        {
            // Processing logic...
        }
    }

    bool IsValid([NotNullWhen(true)]) string? line) 
    {
        return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
    }
}
*/

