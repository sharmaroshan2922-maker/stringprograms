using System;

class StartEnd
{
    static void Main2()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        bool start = str.StartsWith("Hello");
        bool end = str.EndsWith("C#");

        Console.WriteLine($"Starts with Hello: {start}");
        Console.WriteLine($"Ends with C#: {end}");
    }
}
