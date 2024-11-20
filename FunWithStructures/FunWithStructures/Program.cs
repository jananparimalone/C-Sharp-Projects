// See https://aka.ms/new-console-template for more information

Console.WriteLine("***** A First Look at Structures *****\n");
// Create an initial Point
Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();

// Adjust the Xand Y values
myPoint.Increment();
myPoint.Display();
Console.ReadLine();

// Something to note about the configuration of this struct would be
// that if you do not create an X or Y coordinate value at all it will throw an error
// Consider this:
// Point p1;
// p1.X = 10;
// p1.Display();
// This will throw an error!
// Must assign both fields like so:
// Point p2;
// p2.X = 10;
// p2.Y = 10;
// p2.Display;

Console.WriteLine("===> Using the default constructor");
// Set all fields to default values
// using the new default constructor
Point p1 = new Point();
// Prints X=0, Y=0
p1.Display();
Console.ReadLine();

Console.WriteLine("===> Using a custom constructor");
// Call custom constructor 
Point2 p2 = new Point2(50, 60);
// Prints X=50, Y=60
p2.Display();
Console.ReadLine();

Console.WriteLine("===> Declaring individual struct field read only");
PointWithReadOnly p3 =
    new PointWithReadOnly(50,60, "Point w/RO");
p3.Display();
Console.ReadLine();

Console.WriteLine("===> Create and dispose of the new struct");
var s = new DisposableRefStruct(50, 60);
s.Display();
Console.WriteLine("Press any key to dispose...");
Console.ReadLine();
s.Dispose();
Console.ReadLine();

struct Point
{
    // Fields of the structure
    public int X = 5;
    public int Y = 7;

    // Parameterless constructor
    // The parameterless constructor no longer needs to initialize the X and Y values
    // since the structure fields are declared above (line 44 + 45)
    public Point() {}

    // A custom constructor
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    // Add 1 to the (X, Y) position
    public void Increment()
    {
        X++; Y++;
    }

    // Subtract 1 from the (X, Y) position
    public void Decrement()
    {
        X--; Y--;
    }

    // Display the current position
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

struct Point2
{
    // Fields of the structure
    public int X;
    public int Y;

    // A custom constructor
    public Point2(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

// Below displays the construction of a ready only point
// AKA an immutable string which means after its construction
// the points can not be changed
readonly struct ReadOnlyPoint
{
    // Fields of the structure
    public int X { get; }
    public int Y { get; }

    // Display the current positionand name
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }

    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
}

struct PointWithReadOnly
{
    // Fields of the structure
    public int X;
    public readonly int Y;
    public readonly string Name;

    // Display the current position and name
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }

    // A custom constructor
    public PointWithReadOnly(int xPos, int yPos, string name)
    {
        X = xPos;
        Y = yPos;
        Name = name;
    }
}

// Creating a reference struct
ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    // A custom constructor
    public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
        Console.WriteLine("Created!");
    }
    public void Dispose()
    {
        Console.WriteLine("Disposed");
    }
}
