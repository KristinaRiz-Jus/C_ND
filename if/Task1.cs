using System;

namespace task1
{
    class Task1
{
public static void Run()
{
    Console.WriteLine("Įveskite a ir b:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    if (a > b)
        Console.WriteLine("a > b");
    else
        Console.WriteLine("a <= b");
}
}
}
