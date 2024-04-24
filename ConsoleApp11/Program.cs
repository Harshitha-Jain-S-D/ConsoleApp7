using System;

class DigitAdder
{
    static void Main()
    {
        Console.WriteLine("Enter a five-digit number:");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10000 && number <= 99999)
        {
            int newNumber = AddOneToDigits(number);
            Console.WriteLine($"New number after adding 1 to each digit: {newNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a five-digit number.");
        }
    }

    static int AddOneToDigits(int number)
    {
        int result = 0;
        int multiplier = 1;
        while (number > 0)
        {
            int digit = number % 10;
            digit = (digit + 1) % 10; // Adding 1 to the digit and taking modulus to handle overflow
            result += digit * multiplier;
            multiplier *= 10;
            number /= 10;
        }
        return result;
    }
}