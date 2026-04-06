using System;

namespace masyvai
{
    class Task22
    {
        public static void Run()
        {
            Console.WriteLine("Įveskite n ir m:");
            int n = int.Parse(Console.ReadLine()!);
            int m = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Įveskite pirmą masyvą:");
            int[,] a = ReadMatrix(n, m, "A");

            Console.WriteLine("Įveskite antrą masyvą:");
            int[,] b = ReadMatrix(n, m, "B");

            int[,] sum = SumMatrices(a, b);

            Console.WriteLine("Sudėtis:");
            PrintMatrix(sum);
        }

        // Metodas, skaitantis n x m masyvą iš vartotojo
        static int[,] ReadMatrix(int n, int m, string name)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{name}[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine()!);
                }

            return matrix;
        }

        // Metodas, atspausdinantis masyvą
        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        // Metodas, grąžinantis dviejų masyvų sumą
        static int[,] SumMatrices(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            int[,] sum = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    sum[i, j] = a[i, j] + b[i, j];

            return sum;
        }
    }
}