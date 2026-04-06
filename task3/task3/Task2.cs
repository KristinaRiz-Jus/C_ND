using System;

class Task2
{
    public static void Run()
    {
        string text = "Šitas filmas yra kvailas ir nuobodus";

        text = text.Replace("kvailas", "***").Replace("nuobodus", "***");

        Console.WriteLine(text);
    }
}