using System;

class Task7
{
    public static void Run()
    {
        Console.WriteLine("Įveskite val ir min:");
        int val = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());

        int viso = val * 60 + min;

        Console.WriteLine("Minutės nuo vidurnakčio: " + viso);
    }
}