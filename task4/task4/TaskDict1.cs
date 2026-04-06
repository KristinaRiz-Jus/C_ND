using System;
using System.Collections.Generic;
using System.Linq;

namespace masyvai
{
    class TaskDict1
    {
        public static void Run()
        {
            Console.Write("Įveskite sakinį: ");
            string input = Console.ReadLine()!;

            string[] words = input.ToLower()
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict[word] = 1;
            }

            var sorted = dict.OrderByDescending(x => x.Value);

            Console.WriteLine("Rezultatai:");
            foreach (var pair in sorted)
                Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}