using System;

class Task6
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);
        int suma = 0;

        for (int i = 1; i <= n; i++)
            suma += i;

        Console.WriteLine("Suma: " + suma);
    }
}