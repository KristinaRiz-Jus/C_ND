using System;
using System.Collections.Generic;

class TaskList3
{
    public static void Run()
    {
        List<int> numbers = new List<int> { 1, 2, 1, 2, 3, 4, 1, 2, 3 };
        List<int> longest = new List<int>();
        List<int> current = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (current.Count == 0 || numbers[i] > current[^1])
            {
                current.Add(numbers[i]);
            }
            else
            {
                if (current.Count > longest.Count)
                    longest = new List<int>(current);
                current = new List<int> { numbers[i] };
            }
        }

        if (current.Count > longest.Count)
            longest = current;

        Console.WriteLine("Ilgiausia didėjanti seka: " + string.Join(", ", longest));
    }
}