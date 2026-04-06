using System;
using System.Collections.Generic;

namespace masyvai
{
    class TaskDict2
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\n1 - Pridėti");
                Console.WriteLine("2 - Pašalinti");
                Console.WriteLine("3 - Ieškoti");
                Console.WriteLine("4 - Rodyti visus");
                Console.WriteLine("0 - Išeiti");

                Console.Write("Pasirinkimas: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1": Add(); break;
                    case "2": Remove(); break;
                    case "3": Search(); break;
                    case "4": PrintAll(); break;
                    case "0": return;
                    default: Console.WriteLine("Neteisingas pasirinkimas"); break;
                }
            }
        }

        static void Add()
        {
            Console.Write("Vardas: ");
            string name = Console.ReadLine()!;

            Console.Write("Telefonas: ");
            string phone = Console.ReadLine()!;

            phoneBook[name] = phone;
        }

        static void Remove()
        {
            Console.Write("Vardas: ");
            string name = Console.ReadLine()!;

            if (phoneBook.Remove(name))
                Console.WriteLine("Pašalinta");
            else
                Console.WriteLine("Nerasta");
        }

        static void Search()
        {
            Console.Write("Vardas: ");
            string name = Console.ReadLine()!;

            if (phoneBook.TryGetValue(name, out string phone))
                Console.WriteLine($"Telefonas: {phone}");
            else
                Console.WriteLine("Nerasta");
        }

        static void PrintAll()
        {
            foreach (var p in phoneBook)
                Console.WriteLine($"{p.Key} : {p.Value}");
        }
    }
}