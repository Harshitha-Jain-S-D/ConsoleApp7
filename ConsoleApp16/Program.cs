using System;

class RightAngleTriangleIncreasingNumbers
{
    static void Main()
    {
        int rows = 5; // Number of rows in the triangle

        Console.WriteLine("Right-angle triangle pattern with increasing numbers:");
        DisplayRightAngleTriangle(rows);
    }

    static void DisplayRightAngleTriangle(int numRows)
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