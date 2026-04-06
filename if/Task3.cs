using System;

class Task3
{
    public static void Run()
    {
        Console.WriteLine("Įveskite a, b ir c:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int max = a;

        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine("Didžiausias: " + max);
    }
}