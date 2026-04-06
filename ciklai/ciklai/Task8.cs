using System;

class Task8
{
    public static void Run()
    {
        Console.WriteLine("Įveskite n:");
        int n = int.Parse(Console.ReadLine()!);
        int lyginiu = 0;
        int nelyginiu = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine()!);

            if (x % 2 == 0)
                lyginiu += x;
            else
                nelyginiu += x;
        }

        Console.WriteLine("Lyginių suma: " + lyginiu);
        Console.WriteLine("Nelyginių suma: " + nelyginiu);
    }
}