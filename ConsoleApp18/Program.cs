using System;

class PrimeNumberFinder
{
    static void Main()
    {
        Console.WriteLine("Enter the starting number of the range:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ending number of the range:");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"The prime numbers between {start} and {end} are:");
        PrintPrimeNumbers(start, end);
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void PrintPrimeNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}