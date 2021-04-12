using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 10;
            int Max = 99;
            int temp;
            int[] lijst1 = new int[10];
            Random randNum = new Random();
            for (int i = 0; i < lijst1.Length; i++)
            {
                lijst1[i] = randNum.Next(Min, Max);
            }
            Console.WriteLine("Array voor: ");
            PrintArray(lijst1);
            for (int p = 0; p <= lijst1.Length - 2; p++)
            {
                for (int i = 0; i <= lijst1.Length - 2; i++)
                {
                    if (lijst1[i] > lijst1[i + 1])
                    {
                        temp = lijst1[i + 1];
                        lijst1[i + 1] = lijst1[i];
                        lijst1[i] = temp;
                    }
                }
                PrintArray(lijst1);
            }
            static void PrintArray(int[] lijst1){
                Console.WriteLine("");
                for (int i = 0; i < lijst1.Length; i++)
                {
                    Console.Write(lijst1[i]);
                    if (i < lijst1.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
