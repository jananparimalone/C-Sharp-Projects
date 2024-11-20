// See https://aka.ms/new-console-template for more information
Console.WriteLine("**** Fun With Enums ****");
Console.WriteLine();
// Make an EmpyTypeEnum variable
EmpTypeEnum emp = EmpTypeEnum.Contractor;
EmpTypeEnum emp2 = EmpTypeEnum.Grunt;
AskForBonus(emp);
Console.ReadLine();

Console.WriteLine("2 techniques to see the storage type for the enum...");
// Print storage for the enum
Console.WriteLine("EmpTypeEnum uses a {0} for storage",
    Enum.GetUnderlyingType(emp.GetType()));
// Print storage using typeof()
Console.WriteLine("EmpTypeEnum uses a {0} for storage",
    Enum.GetUnderlyingType(typeof(EmpTypeEnum)));
Console.ReadLine();

// Emp is defined in this scope on line 5, so no need to do it again
// Line 21 + 22 print out the emp variable value
Console.WriteLine("Printing out the defined scope for emp enum var...");
Console.WriteLine("emp is a {0}.", emp.ToString());
Console.ReadLine();
// Line 24 prints Contractor = 100
Console.WriteLine("Printing out the value of the enumeration variable...");
Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);
Console.ReadLine();

Console.WriteLine("Testing my EvaluateEnum() method...");

// These types are enums in the System namespace
DayOfWeek day = DayOfWeek.Monday;
ConsoleColor cc = ConsoleColor.Gray;

EvaluateEnum(emp2);
EvaluateEnum(day);
EvaluateEnum(cc);
Console.ReadLine();


// Enums as parameters
static void AskForBonus(EmpTypeEnum e)
{
    switch (e)
    {
        case EmpTypeEnum.Manager:
            Console.WriteLine("How about stock options instead?");
            break;
        case EmpTypeEnum.Grunt:
            Console.WriteLine("You've got to be kidding me...");
            break;
        case EmpTypeEnum.Contractor:
            Console.WriteLine("You already get enough cash...");
            break;
        case EmpTypeEnum.VicePresident:
            Console.WriteLine("VERY GOOD, Sir!");
            break;
    }
}

// Let's write a method to print out each name-value pair within any enumeration we pass it
static void EvaluateEnum(System.Enum e)
{
    Console.WriteLine(" => Information about {0}", e.GetType().Name);
    Console.WriteLine("Underlying storage type {0}",
        Enum.GetUnderlyingType(e.GetType()));
    // Get all name-value pairs for incoming parameter
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members.", enumData.Length);

    // Now show the string name and associate value using the D format
    // flag (see Chapter 3)
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine("Name: {0}, Value: {0:D}",
            enumData.GetValue(i));
    }
}

// Here are some way you could try to call the enumerations that won't work

/*
static void ThisMethodWillNotCompile()
{
    // Error! SalesManager is not in the EmpTypeEnum enum!
    EmpTypeEnum emp = EmpTypeEnum.SalesManager;
    // Error! Forgot to scope Grunt value to EmpTypeEnum enum!
    emp = Grunt;
}
*/

// Local functions go here:

// A custom enumeration
// enums do not need to begin with 0 they can begin with any #
// they also do not need to be in order

/*
enum EmpTypeEnum
{
    Manager, // = 0
    Grunt, // = 1
    Contractor, // = 2
    VicePresident // = 3
}
*/

// You also can set the enum type, the default one is an int but lets create a byte for example

enum EmpTypeEnum : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    // Can't use 999 because that value can not be stored in a byte
    VicePresident = 23 // = 999
}


