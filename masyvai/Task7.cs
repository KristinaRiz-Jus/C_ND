using System;

class Task7
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);
        Random rand = new Random();
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = rand.Next(0, 100);  // atsitiktiniai skaičiai 0–99

        Console.WriteLine("Pradinis masyvas:");
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();

        // Bubble sort
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }

        Console.WriteLine("Surikiuotas masyvas:");
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();
    }
}