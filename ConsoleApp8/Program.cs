using System;
using System.Reflection.PortableExecutable;

class StringReverser
{
    static void Main()
    {
        string originalString = "Heloo World!!";
        string reversedString = ReversedString(originalString);

        Console.WriteLine(reversedString);
    }
    static string ReversedString (string input)
    {
        Char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}