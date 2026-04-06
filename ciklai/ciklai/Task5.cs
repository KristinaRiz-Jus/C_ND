using System;

class Task5
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}