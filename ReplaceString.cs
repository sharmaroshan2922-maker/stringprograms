using System;

class ReplaceString
{
    static void Main5()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = str.Replace("Java", "C#");

        Console.WriteLine($"Original String: {str}");
        Console.WriteLine($"After Replacement: {result}");
    }
}
