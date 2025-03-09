using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[4, 4];

        Console.WriteLine("Digite os 16 elementos da matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int somaA = 0, somaB = 0, somaC = 0, somaD = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i < 2 && j < 2)
                    somaA += A[i, j];

                if (i >= 2 && j >= 2)
                    somaB += A[i, j];

                if (i > j)
                    somaC += A[i, j];

                if (i < j)
                    somaD += A[i, j];
            }
        }

        Console.WriteLine($"Soma da região (a): {somaA}");
        Console.WriteLine($"Soma da região (b): {somaB}");
        Console.WriteLine($"Soma da região (c): {somaC}");
        Console.WriteLine($"Soma da região (d): {somaD}");
    }
}
