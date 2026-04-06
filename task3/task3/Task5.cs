using System;

class Task5
{
    public static void Run()
    {
        string s = "aba aba aba";
        string value = "aba";

        int startIndex = 0;

        Console.WriteLine($"Visų '{value}' pasikartojimų indeksai:");

        while (true)
        {
            int index = s.IndexOf(value, startIndex);
            if (index == -1) break;

            Console.WriteLine(index);

            startIndex = index + 1; // kitam paieškos ciklui
        }
    }
}