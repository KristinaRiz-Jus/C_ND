using System;

class Task7
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine()!);
            suma += x;
        }

        Console.WriteLine("Suma: " + suma);
    }
}