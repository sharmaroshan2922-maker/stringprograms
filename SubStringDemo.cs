using System;

class SubStringDemo
{
    static void Main4()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = str.Substring(0, 5);

        Console.WriteLine($"First 5 characters: {result}");
    }
}