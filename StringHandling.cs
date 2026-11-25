using System;

class StringHandling
{
    static void Main1()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        bool starts = str.StartsWith("Hello");
        bool ends = str.EndsWith("C#");

     
        int position = str.IndexOf('a');

        string firstFive = "";

        if (str.Length >= 5)
        {
            firstFive = str.Substring(0, 5);
        }
        else
        {
            firstFive = str;
        }

      
        string replaced = str.Replace("Java", "C#");

      
        Console.Write("Enter comma-separated words: ");
        string commaString = Console.ReadLine();

        string[] words = commaString.Split(',');


        Console.Write("Enter first string for comparison: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string for comparison: ");
        string str2 = Console.ReadLine();

        bool equal = str1 == str2;

        
        bool isEmpty = String.IsNullOrEmpty(str);

        Console.WriteLine("\n--- String Handling Results ---");

        Console.WriteLine($"Starts with 'Hello': {starts}");
        Console.WriteLine($"Ends with 'C#': {ends}");
        Console.WriteLine($"Position of first 'a': {position}");
        Console.WriteLine($"First 5 characters: {firstFive}");
        Console.WriteLine($"After replacing Java with C#: {replaced}");

        Console.WriteLine("Split Words:");

        foreach (string word in words)
        {
            Console.WriteLine(word.Trim());
        }

        Console.WriteLine($"Two strings are equal: {equal}");
        Console.WriteLine($"String is null or empty: {isEmpty}");
    }
}
