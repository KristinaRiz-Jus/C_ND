using System;

class Task2
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Įveskite arr[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Masyvas atbuline tvarka:");
        for (int i = n - 1; i >= 0; i--)
            Console.WriteLine(arr[i]);
    }
}