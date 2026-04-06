using System;

class Task10
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);

        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine("Fibonacci: " + a);
    }
}