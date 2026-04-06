using System;

class Task6
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n ir m:");
        int n = int.Parse(Console.ReadLine()!);
        int m = int.Parse(Console.ReadLine()!);

        int[,] a = new int[n, m];
        int[,] b = new int[n, m];
        int[,] mul = new int[n, m];

        Console.WriteLine("Įveskite pirmą masyvą:");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                a[i, j] = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Įveskite antrą masyvą:");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                b[i, j] = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                mul[i, j] = a[i, j] * b[i, j];

        Console.WriteLine("Daugyba:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(mul[i, j] + "\t");
            Console.WriteLine();
        }
    }
}