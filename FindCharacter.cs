using System;

class FindCharacter
{
    static void Main3()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int position = str.IndexOf('a');

        Console.WriteLine($"Position of first 'a': {position}");
    }
}