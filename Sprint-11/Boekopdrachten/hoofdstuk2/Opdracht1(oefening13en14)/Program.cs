using System;

namespace Opdracht1_oefening13en14_
{
    class Program
    {
        static void Main(string[] args)
        {
            float Output = 0;
            string[] whiskys = new string[5];

            whiskys[0] = "Caol Ila";
            whiskys[1] = "MacAllan";
            whiskys[2] = "Arran";
            whiskys[3] = "Maltman";
            whiskys[4] = "Nikka";

            Console.WriteLine("Wat wilt u drinken?");
            for (int i = 0; i < whiskys.Length; i++)
            {
                Console.WriteLine($"{i} {whiskys[i]}");
            }
            Console.Write("Kies een getal: ");

            var Input = Console.ReadLine().ToLower();
            var InputParse = Single.TryParse(Input, out Output);
            int Intput = Convert.ToInt32(Output);
            if (InputParse == true || Output >= whiskys.Length)
            {
                Console.WriteLine($"Uw geselecteerde drankje is: " + whiskys[Intput]);
            }
            else
            {
                Console.WriteLine("Er is iets misgegaan");

            }
        }
    }
}
