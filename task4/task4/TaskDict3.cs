using System;
using System.Collections.Generic;

namespace masyvai
{
    class TaskDict3
    {
        public static void Run()
        {
            Console.Write("Įveskite pirmą eilutę: ");
            string s1 = Console.ReadLine()!;

            Console.Write("Įveskite antrą eilutę: ");
            string s2 = Console.ReadLine()!;

            bool result = AreAnagrams(s1, s2);

            Console.WriteLine(result ? "Anagramos" : "Ne anagramos");
        }

        static bool AreAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s1)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;
            }

            foreach (char c in s2)
            {
                if (!dict.ContainsKey(c))
                    return false;

                dict[c]--;

                if (dict[c] < 0)
                    return false;
            }

            return true;
        }
    }
}