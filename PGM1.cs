using System;

class Program
{
    static string StrNthWord(string str, int nthWord)
    {
        // Split the string by '#' delimiter
        string[] words = str.Split('#', StringSplitOptions.RemoveEmptyEntries);
        // Check if nthWord is within the range of words
        if (nthWord > 0 && nthWord <= words.Length)
        {
            return words[nthWord - 1];
        }
        else
        {
            return "Invalid nthWord";
        }
    }

    static void Main()
    {
        string str = "Deep#sea#fishing #is #a#dangerous#occupation#because#of #the #rough#sea";
        Console.WriteLine(StrNthWord(str, 6));  // Output: dangerous
        Console.WriteLine(StrNthWord(str, 2));  // Output: sea
    }
}