using System;

class PyramidPatternNumbers
{
    static void Main()
    {
        int rows = 5; // Number of rows in the pyramid

        Console.WriteLine("Pyramid pattern with numbers increasing by 1:");
        DisplayPyramid(rows);
    }

    static void DisplayPyramid(int numRows)
    {
        int number = 1;
        for (int i = 1; i <= numRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
                number++;
            }
            Console.WriteLine();
        }
    }
}