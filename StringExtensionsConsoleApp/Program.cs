using System;
using StringExtensionsLibrary;

class Program
{
    static void Main()
    {
        string input = "Hello World!";
        bool isUpper = input.StartsWithUpperCase();

        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Starts with uppercase? {isUpper}");
    }
}
