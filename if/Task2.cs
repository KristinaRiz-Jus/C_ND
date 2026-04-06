using System;

class Task2
{
    public static void Run()
    {
        Console.WriteLine("Įveskite a ir b:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("a > b");
        else if (a == b)
            Console.WriteLine("a = b");
        else
            Console.WriteLine("a < b");
    }
}