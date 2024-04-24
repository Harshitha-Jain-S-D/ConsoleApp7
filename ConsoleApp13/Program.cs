using System;

class RightAngleTriangle
{
    static void Main()
    {
        int rows = 4; // Number of rows in the triangle

        Console.WriteLine("Right-angle triangle pattern:");
        DisplayRightAngleTriangle(rows);
    }

    static void DisplayRightAngleTriangle(int numRows)
    {
        for (int i = 1; i <= numRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}