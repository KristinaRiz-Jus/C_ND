using System;

class Task3
{
    public static void Run()
    {
        Console.Write("Įveskite vardą ir pavardę: ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input))
        {
            string[] parts = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 2)
            {
                char firstInitial = char.ToUpper(parts[0][0]);
                char lastInitial = char.ToUpper(parts[1][0]);

                Console.WriteLine($"Inicialai: {firstInitial}.{lastInitial}.");
            }
            else
            {
                Console.WriteLine("Įveskite tiek vardą, tiek pavardę.");
            }
        }
    }
}