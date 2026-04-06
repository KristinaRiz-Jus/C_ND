using System;

class Task6
{
    public static void Run()
    {
        Console.WriteLine("Įveskite metus:");
        int metai = int.Parse(Console.ReadLine());

        if ((metai % 4 == 0 && metai % 100 != 0) || metai % 400 == 0)
            Console.WriteLine("Keliamieji");
        else
            Console.WriteLine("Nekeliamieji");
    }
}