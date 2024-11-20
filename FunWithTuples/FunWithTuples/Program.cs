using System.Drawing;

(string, int, string) values = ("a", 5, "c");
// You could also declare the same variables with the commented statement on line 3 instead
// var values = ("a", 5, "c");
Console.WriteLine("=> Declaring a tuple");
Console.WriteLine($"First item: {values.Item1}");
Console.WriteLine($"Second item: {values.Item2}");
Console.WriteLine($"Third item: {values.Item3}");
Console.ReadLine();
// Another way to do this is you could set the names on the left and the right to achieve the same end like one lines 5 and 6
(string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
// Note that when setting names on the right you must use the keyword var to declare the variable
var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
Console.WriteLine("=> Another tuple declaration technique");
Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
// Using item notation still works!
Console.WriteLine($"First item: {valuesWithNames.Item1}");
Console.WriteLine($"Second item: {valuesWithNames.Item2}");
Console.WriteLine($"Third item: {valuesWithNames.Item3}");
Console.ReadLine();
// Setting the data types specifically triggers the compiler to use the left side
// Below is an example of that
(int Field1, int Field2) example = (Custom1: 5, Custom2: 7);
// (int, int) example = (Custom1:5, Custom2:7);
// Line 27 is an example of nested tuples
var nt = (5, 4, ("a", "b"));
Console.WriteLine("=> Inferred Tuple Names");
var foo = new { Prop1 = "first", Prop2 = "second"};
var bar = (foo.Prop1, foo.Prop2);
Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
Console.ReadLine();
Console.WriteLine("=> Tuples Equality/Inequality");
// lifted conversions
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine(left == nullableMembers); // Also true
// converted types of left is (long, long)
(long a, long b) longTuple = (5, 10);
Console.WriteLine(left == longTuple); // Also true
// comparisons performed on (long, long) tuples
(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(longFirst == longSecond); // Also true
Console.ReadLine();
// Passing tuples as method return values
Console.WriteLine("=> Tuple passed as method return value");
var samples = FillTheseValues();
Console.WriteLine($"Int is: {samples.a}");
Console.WriteLine($"String is: {samples.b}");
Console.WriteLine($"Bool is: {samples.c}");
Console.ReadLine();
Console.WriteLine("=> Discards with tuples");
var (first, _, last) = SplitNames("Phillip F Japiske");
(object first, object, object last) SplitNames(string v)
{
    throw new NotImplementedException();
}

Console.WriteLine($"{first}:{last}");
// Deconstructing tuples
Console.WriteLine("=> Deconstructing tuples");
(int X, int Y) myTuple = (4, 5);
int x = 0;
int y = 0;
(x, y) = myTuple;
Console.WriteLine($"X is: {x}");
Console.WriteLine($"Y is: {y}");
(int x1, int y1) = myTuple;
Console.WriteLine($"x1 is: {x}");
Console.WriteLine($"y1 is: {y}");
// or you can mix assignment declaration
int x2 = 0;
(x2, int y2) = myTuple;
Console.WriteLine($"x2 is: {x}");
Console.WriteLine($"y2 is: {y}");
Point p = new Point(7, 5);
var pointValues = p.Deconstruct();
//Console.WriteLine($"X is: {pointValues.XPos}");
//Console.WriteLine($"X is: {pointValues.YPos}");


static (int a, string b, bool c) FillTheseValues()
{
    return (9, "Enjoy your string", true);
}
// Switch expressions with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins",
        ("rock", "scissors") => "Rock wins",
        ("paper", "rock") => "Paper wins",
        ("paper", "scissors") => "Scissors wins",
        ("scissors", "rock") => "Rock wins",
        ("scissors", "paper") => "Scissors wins",
        (_, _) => "Tie",
    };
}
// You could also write the method for RPS like this
// static string RockPaperScissors(
// (string first, string second) value)
// {
// return value switch
// {
// omitted
// };
// }
struct Point
{
    public int X;
    public int Y;

    public Point(int Xpos, int Ypos)
    {
        X = Xpos;
        Y = Ypos;
    }
    public (int Xpos, int Ypos) Deconstruct() => (X, Y);
}

