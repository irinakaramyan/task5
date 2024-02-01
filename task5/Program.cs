// See https://aka.ms/new-console-template for more information
using System;
class A
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {3, 2, 1},
            {2, 3, 1}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        bool saddlePointFound = false;

        for (int i = 0; i < rows; i++)
        {
            int saddlePointCol = 0;
            int maxInRow = matrix[i, 0];

            
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] > maxInRow)
                {
                    maxInRow = matrix[i, j];
                    saddlePointCol = j;
                }
            }

            
            bool isSaddlePoint = true;
            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, saddlePointCol] < maxInRow)
                {
                    isSaddlePoint = false;
                    break;
                }
            }

            if (isSaddlePoint)
            {
                Console.WriteLine("Saddle point found at position (" + i + ", " + saddlePointCol + ") with element " + maxInRow);
                saddlePointFound = true;
            }
        }

        if (!saddlePointFound)
        {
            Console.WriteLine("no");
        }
    }
}

