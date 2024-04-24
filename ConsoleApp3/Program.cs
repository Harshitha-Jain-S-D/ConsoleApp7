using System;

class Program
{
    static int CountVowelsIfElse(string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        return count;
    }

    static int CountVowelsSwitch(string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    count++;
                    break;
                default:
                    break;
            }
        }
        return count;
    }

    static void Main()
    {
        string inputString = "Anger ärge hearted gentleman with beurdless courage and that when he is exterminated us exterminated he will be unless public opinion rallies to hit support india will be the power by having lost the feest of her fauna";

        int vowelCountIfElse = CountVowelsIfElse(inputString);
        int vowelCountSwitch = CountVowelsSwitch(inputString);

        Console.WriteLine($"Count of vowels using if-else: {vowelCountIfElse}");
        Console.WriteLine($"Count of vowels using switch-case: {vowelCountSwitch}");
    }
}