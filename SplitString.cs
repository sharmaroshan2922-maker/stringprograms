using System;

class SplitString
{
    static void Main6()
    {
        Console.Write("Enter comma-separated words: ");
        string str = Console.ReadLine();

        string[] words = str.Split(',');

        Console.WriteLine("Individual Words:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}