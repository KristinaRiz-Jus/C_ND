using System;
using System.Collections.Generic;
using System.Linq;

class TaskList1
{
    public static void Run()
    {
        List<int> grades = new List<int> { 5, 8, 7, 6, 9 };

        // Pridėti įrašą
        grades.Add(10);
        // Pašalinti įrašą
        grades.Remove(6);

        // Min, Max, Vidurkis
        int min = grades.Min();
        int max = grades.Max();
        double avg = grades.Average();

        // Rūšiavimas
        grades.Sort();

        // Rezultatų atvaizdavimas
        Console.WriteLine("Pažymiai: " + string.Join(", ", grades));
        Console.WriteLine($"Min: {min}, Max: {max}, Vidurkis: {avg:F2}");
    }
}