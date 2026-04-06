using System;

class Task5
{
    public static void Run()
    {
        Console.WriteLine("Įveskite a, b ir c:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Galima sudaryti trikampį");
        else
            Console.WriteLine("Negalima sudaryti trikampio");
    }
}