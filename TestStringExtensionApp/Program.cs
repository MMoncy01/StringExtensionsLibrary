using System;
using StringExtensionsLibrary;

class Program
{
    static void Main(string[] args)
    {
        string test1 = "Hello";
        string test2 = "world";

        Console.WriteLine($"\"{test1}\" starts with uppercase? {test1.StartsWithUpperCase()}");
        Console.WriteLine($"\"{test2}\" starts with uppercase? {test2.StartsWithUpperCase()}");
    }
}
