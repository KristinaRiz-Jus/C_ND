using System;
using System.Collections.Generic;
using System.Linq;

class TaskList2
{
    public static void Run()
    {
        Console.Write("Įveskite n: ");
        int n = int.Parse(Console.ReadLine()!);

        Random rnd = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
            numbers.Add(rnd.Next(1, 11)); // atsitiktinis 1-10

        // Pasikartojantys elementai
        var duplicates = numbers.GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key)
                                .ToList();

        Console.WriteLine("Pradinis sąrašas: " + string.Join(", ", numbers));
        Console.WriteLine("Pasikartojantys elementai: " + string.Join(", ", duplicates));
    }
}