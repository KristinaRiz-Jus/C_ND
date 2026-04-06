using System;

namespace masyvai
{
    class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Įveskite n:");
            int n = int.Parse(Console.ReadLine()!);
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Įveskite arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Masyvas:");
            foreach (int x in arr)
                Console.WriteLine(x);
        }
    }
}