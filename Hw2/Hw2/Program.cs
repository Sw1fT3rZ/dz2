using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = 20;
        int[] A = new int[N];
        List<int> B = new List<int>();
        int countInRange = 0;

        Random rand = new Random();

        Console.WriteLine("Array A:");
        for (int i = 0; i < N; i++)
        {
            A[i] = rand.Next(-200, 200);
            Console.Write(A[i] + " ");

            if (A[i] >= -100 && A[i] <= 100)
            {
                countInRange++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Number of elements in the range -100 to +100: " + countInRange);

        for (int i = 0; i < N; i++)
        {
            if (A[i] <= 888)
            {
                B.Add(A[i]);
            }
        }

        B.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine("Array B after sorting in descending order:");
        foreach (int element in B)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
