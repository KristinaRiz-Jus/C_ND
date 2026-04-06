using System;

class Task6
{
    public static void Run()
    {
        string text = "Tai yra labai ilga eilutė, kuri turi būti sutrumpinta";

        string shortened = Shorten(text);
        Console.WriteLine(shortened);
    }

    static string Shorten(string input)
    {
        if (input.Length <= 15)
            return input;
        else
            return input.Substring(0, 12) + "..."; // 12 + 3 = 15 simbolių
    }
}