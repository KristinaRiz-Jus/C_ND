using System;

class Task4
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n ir m:");
        int n = int.Parse(Console.ReadLine()!);
        int m = int.Parse(Console.ReadLine()!);
        int[,] arr = new int[n, m];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                Console.Write($"arr[{i},{j}] = ");
                arr[i, j] = int.Parse(Console.ReadLine()!);
            }

        Console.WriteLine("Dvimatis masyvas:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(arr[i, j] + "\t");
            Console.WriteLine();
        }
    }
}