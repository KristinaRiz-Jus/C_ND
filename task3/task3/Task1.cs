using System;

class Task1
{
    public static void Run()
    {
        string input = "   Vilnius   ";
        string trimmed = input.Trim(); // pašalina tarpus iš abiejų pusių

        bool startsWithVil = trimmed.StartsWith("Vil");
        bool endsWithIus = trimmed.EndsWith("ius");

        Console.WriteLine($"Pašalinti tarpai: '{trimmed}'");
        Console.WriteLine($"Prasideda 'Vil': {startsWithVil}");
        Console.WriteLine($"Baigiasi 'ius': {endsWithIus}");
    }
}