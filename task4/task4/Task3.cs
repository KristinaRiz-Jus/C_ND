using System;
using System.Collections.Generic;

class Task3
{
    public static void Run()
    {
        Console.Write("Įveskite tekstą: ");
        string input = Console.ReadLine()!;

        Stack<char> stack = new Stack<char>();
        bool valid = true;

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    valid = false;
                    break;
                }

                char top = stack.Pop();

                if (!IsMatching(top, c))
                {
                    valid = false;
                    break;
                }
            }
        }

        if (stack.Count > 0) valid = false;

        Console.WriteLine(valid ? "Gerai" : "Blogai");
    }

    static bool IsMatching(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '[' && close == ']') ||
               (open == '{' && close == '}');
    }
}