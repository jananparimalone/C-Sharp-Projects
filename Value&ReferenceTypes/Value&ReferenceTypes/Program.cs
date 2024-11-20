// See https://aka.ms/new-console-template for more information
using System.Drawing;

ValueTypeAssignment();
Console.ReadLine();
ReferenceTypeAssignment();
Console.ReadLine();
ValueTypeContainingRefType();
Console.ReadLine();
// Passing ref-types by value
Console.WriteLine("***** Passing Person object by value *****");
Person fred = new Person("Fred", 12);
Console.WriteLine("\nBefore by value call, Person is:");
fred.Display();

SendAPersonByValue(fred);
Console.WriteLine("\nAfter by value call, Person is:");
fred.Display();
Console.ReadLine();

// Passing reference types by reference
Console.WriteLine("***** Passing Person object by reference *****");
Person mel = new Person("Mel", 23);
Console.WriteLine("Before reference call, Person is:");
mel.Display();
Console.ReadLine();

SendAPersonByReference(ref mel);
Console.WriteLine("After ref call, Person is:");
mel.Display();
Console.ReadLine();

// Local structures are popped off the stack
// when a method returns
static void LocalValueTypes()
{
    // Recall! "int" is really a System.Int32 structure
    int i = 0;

    // Recall! Point is a structure type
    Point p = new Point();
} // "i" and "p" popped off the stack here

/*
// Structures and enumerations implicitly extend System.ValueType
public abstract class ValueType : object
{
    public virtual bool Equals(object obj);
    public virtual int GetHashCode();
    public Type GetType();
    public virtual string ToString();
}
*/

static void ValueTypeAssignment() 
{ 

    Console.WriteLine("*** Assigning value types ***\n");
    Point p1 = new Point(10, 10);
    Point p2 = p1;

    // Print both points
    p1.Display();
    p2.Display();

    // Change p1.X and print again p2.X is not changed
    p1.X = 100;
    Console.WriteLine("\n=>Changed p1.X\n");
    p1.Display();
    p2.Display();
}

static void ReferenceTypeAssignment()
{

    Console.WriteLine("*** Assigning reference types ***\n");
    PointRef p1 = new PointRef(10, 10);
    PointRef p2 = p1;

    // Print both point refs
    p1.Display();
    p2.Display();

    // Change p1.X and print again
    p1.X = 100;
    Console.WriteLine("\n=>Changed p1.X\n");
    p1.Display();
    p2.Display();
}

// Defining and invoking a method to figure out if an objects state is fully copied
// or will reference to the object be copied
// We can see that when we change the value of the informational string
// using the r2 reference, the r1 reference displays the same value
// by default, when a value type contains other reference types,
// assignments results in a copy of references
static void ValueTypeContainingRefType()
{
    // Create the first Rectangle
    Console.WriteLine("-> Creating r1");
    Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

    // Now assign a new rectangle to r1
    Console.WriteLine("-> Assigning r2 to r1");
    Rectangle r2 = r1;

    // Change some values of r2
    Console.WriteLine("-> Changing values of r2");
    r2.RectInfo.InfoString = "This is new info";
    r2.RectBottom = 4444;

    // Print both of rectangles
    r1.Display();
    r2.Display();
}

static void SendAPersonByValue(Person p)
{
    // Change the age of "p"?
    p.personAge = 99;

    // Will the caller see this reassignment?
    p = new Person("Nikki", 99);
}

// Passing reference type by reference
static void SendAPersonByReference(ref Person p)
{
    // Change some data of "p"
    p.personAge = 555;

    // "p" is now pointing to a new object on the heap!
    p = new Person("Nikki", 999);
}

// Classes are always reference types
class PointRef
{
    public int X { get; set; }
    public int Y { get; set; }
    // Same members as the Point structure...
    // Be sure to change your constructor name to PointRef!
    public PointRef(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}

public static class PointExtensions
{
    public static void Display(this Point point)
    {
        Console.WriteLine($"X = {point.X}, Y = {point.Y}");
    }
}

// Example of a value type containing a reference type below
class ShapeInfo
{
    public string InfoString;
    public ShapeInfo(string info)
    {
        InfoString = info;
    }
}

// Containing a variable of this class type within a value type called Rectangle
// Also using a custom constructor
struct Rectangle
{
    // The rectangle structure contains a reference type member
    public ShapeInfo RectInfo;

    public int RectTop, RectLeft, RectBottom, RectRight;

    public Rectangle(string info, int top, int left, int bottom, int right)
    {
        RectInfo = new ShapeInfo(info);
        RectTop = top; RectBottom = bottom;
        RectLeft = left; RectRight = right;
    }

    public void Display()
    {
        Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
            "Left = {3}, Right = {4}",
            RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
    }
}

// Passing reference types by value
class Person
{
    public string personName;
    public int personAge;

    // Constructors
    public Person(string name, int age)
    {
        personName = name;
        personAge = age;
    }
    public Person() { }

    public void Display()
    {
        Console.WriteLine("Name: {0}, Age {1}", personName, personAge);
    }
}