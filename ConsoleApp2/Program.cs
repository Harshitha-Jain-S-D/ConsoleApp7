using System;

class Program
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a five-digit number: ");
        string input = Console.ReadLine();

        // Check if the input is a five-digit number
        if (input.Length != 5 || !int.TryParse(input, out int number))
        {
            Console.WriteLine("Please enter a valid five-digit number.");
        }
        else
        {
            // Convert the input to an integer
            number = int.Parse(input);

            // Extract each digit
            int digit1 = (number / 10000) % 10;
            int digit2 = (number / 1000) % 10;
            int digit3 = (number / 100) % 10;
            int digit4 = (number / 10) % 10;
            int digit5 = number % 10;

            // Calculate the new digits based on the given rule
            int newDigit1 = (digit1 + 1) % 10;
            int newDigit2 = (digit2 + 1) % 10;
            int newDigit3 = (digit3 + 1) % 10;
            int newDigit4 = (digit4 + 1) % 10;
            int newDigit5 = (digit5 + 1) % 10;

            // Construct the new number
            int newNumber = newDigit1 * 10000 + newDigit2 * 1000 + newDigit3 * 100 + newDigit4 * 10 + newDigit5;

            // Print the new number
            Console.WriteLine("New number: " + newNumber);
        }
    }
}