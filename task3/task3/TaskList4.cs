using System;
using System.Collections.Generic;

class TaskList4
{
    public static void Run()
    {
        Console.Write("Įveskite n: ");
        int n = int.Parse(Console.ReadLine()!);

        Random rnd = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
            numbers.Add(rnd.Next(1, 101)); // 1-100

        Console.Write("Įveskite sumą: ");
        int targetSum = int.Parse(Console.ReadLine()!);

        List<(int, int)> pairs = new List<(int, int)>();

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] + numbers[j] == targetSum)
                {
                    pairs.Add((numbers[i], numbers[j]));
                }
            }
        }

        Console.WriteLine("Sugeneruotas sąrašas: " + string.Join(", ", numbers));
        Console.WriteLine("Poros, kurių suma = " + targetSum + ":");
        foreach (var (a, b) in pairs)
            Console.WriteLine($"{a} + {b} = {targetSum}");
    }
}