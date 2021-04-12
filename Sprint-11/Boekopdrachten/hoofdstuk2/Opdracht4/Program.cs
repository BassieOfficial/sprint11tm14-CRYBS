using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 10;
            int Max = 99;

            // this declares an integer array with 10 elements
            // and initializes all of them to their default value
            // which is zero
            int[] lijst1 = new int[10];
            int[] lijst2 = new int[10];
            int[] lijstsom = new int[10];
            Random randNum = new Random();
            for (int i = 0; i < lijst1.Length; i++)
            {
                lijst1[i] = randNum.Next(Min, Max);
                lijst2[i] = randNum.Next(Min, Max);
                lijstsom[i] = lijst1[i] + lijst2[i];
            }
            Console.WriteLine(lijst1);
            Console.Write("Array 1: ");
            for (int i = 0; i < lijst1.Length; i++)
            {
                Console.Write(lijst1[i]);
                if (i < lijst1.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("");
            Console.Write("Array 2: ");
            for (int i = 0; i < lijst2.Length; i++)
            {
                Console.Write(lijst2[i]);
                if (i < lijst2.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("");
            Console.Write("Array T: ");
            for (int i = 0; i < lijstsom.Length; i++)
            {
                Console.Write(lijstsom[i]);
                if (i < lijstsom.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
