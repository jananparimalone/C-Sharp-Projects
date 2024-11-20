// See https://aka.ms/new-console-template for more information
using static FunWithMethodOverloading.AddOperations;

Console.WriteLine("***** Fun with Method Overloading *****");
// Calls int version of Add()
Console.WriteLine(Add(10, 10));
// Calls long version of Add() (using new digit separator)
Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
// Calls double version of Add()
Console.WriteLine(Add(4.3, 4.4));
Console.ReadLine();
