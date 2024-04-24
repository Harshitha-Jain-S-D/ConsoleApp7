using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number of the range: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the ending number of the range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}