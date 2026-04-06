using System;

class Task7
{
    public static void Run()
    {
        string[] data = { "Mantas,29,198", "Jonas,31,182", "Asta,25,170" };

        string[] name = new string[data.Length];
        int[] age = new int[data.Length];
        int[] height = new int[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            string[] parts = data[i].Split(','); // skaidome pagal kablelį
            name[i] = parts[0];
            age[i] = int.Parse(parts[1]);
            height[i] = int.Parse(parts[2]);
        }

        // Išvedimas
        Console.WriteLine("Vardai: " + string.Join(", ", name));
        Console.WriteLine("Amžius: " + string.Join(", ", age));
        Console.WriteLine("Ūgis: " + string.Join(", ", height));
    }
}