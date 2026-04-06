using System;

class Task4
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= n; i++)
            Console.WriteLine(i);
    }
}