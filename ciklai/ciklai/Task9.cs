using System;

class Task9
{
    public static void Run()
    {
        Console.WriteLine("Įveskite a ir b:");
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine("DBD: " + a);
    }
}