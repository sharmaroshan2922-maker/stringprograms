using System;

class CompareString
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        bool result = str1 == str2;

        Console.WriteLine($"Both strings are equal: {result}");
    }
}
