using System;
using System.Collections.Generic;

    class Task1
{
    public static void Run()
    {
        Console.Write("Įveskite n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Įveskite k: ");
        int k = int.Parse(Console.ReadLine()!);

        Queue<int> queue = new Queue<int>();
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
            queue.Enqueue(rnd.Next(1, 101));

        Console.WriteLine("Pradinė eilė: " + string.Join(", ", queue));

        Queue<int> result = ReverseFirstK(queue, k);

        Console.WriteLine("Rezultatas: " + string.Join(", ", result));
    }

    static Queue<int> ReverseFirstK(Queue<int> q, int k)
    {
        if (k <= 0 || k > q.Count) return q;

        Stack<int> stack = new Stack<int>();

        // paimam pirmus k elementus į stack (apsivers)
        for (int i = 0; i < k; i++)
            stack.Push(q.Dequeue());

        // iš stack atgal į queue
        while (stack.Count > 0)
            q.Enqueue(stack.Pop());

        // likusius elementus perkeliam į galą
        int size = q.Count;
        for (int i = 0; i < size - k; i++)
            q.Enqueue(q.Dequeue());

        return q;
    }
}