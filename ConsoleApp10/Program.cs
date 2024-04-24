using System;

class NthWordFinder
{
    static void Main()
    {
        string inputString = "Deep#sea#fishing#is#a#dangerous#occupation#because#of#the#rough#sea#";
        int n = 5; // Example: Get the 5th word

        string nthWord = GetNthWord(inputString, n);
        Console.WriteLine($"The {n}th word is: {nthWord}");
    }

    static string GetNthWord(string input, int n)
    {
        string[] words = input.Split('#');
        if (n >= 1 && n <= words.Length)
        {
            return words[n - 1]; // Adjusting for 0-based index
        }
        else
        {
            return "Invalid index";
        }
    }
}