using System;

class Task3
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);
        int[] arr = new int[n];
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Įveskite arr[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine()!);
            suma += arr[i];
        }

        Console.WriteLine("Suma: " + suma);
    }
}