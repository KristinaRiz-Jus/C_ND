using System;

class Task4
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("Lyginis");
        else
            Console.WriteLine("Nelyginis");
    }
}