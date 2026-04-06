using System;
using System.Collections.Generic;

class Task2
{
    public static void Run()
    {
        Console.Write("Įveskite tekstą: ");
        string input = Console.ReadLine()!;

        Queue<char> queue = new Queue<char>();
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
            {
                char lower = char.ToLower(c);
                queue.Enqueue(lower);
                stack.Push(lower);
            }
        }

        bool isPalindrome = true;

        while (queue.Count > 0)
        {
            if (queue.Dequeue() != stack.Pop())
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine(isPalindrome ? "Palindromas" : "Ne palindromas");
    }
}