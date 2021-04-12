using System;

namespace Priemgetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declareert de variablen
            int num, i, ctr, getal;
            int counter = 0;

            //Vraagt en leest hoeveel priemgetallen er gegenereert moeten worden
            Console.Write("Hoeveel priemgetallen wilt u genereren: ");
            getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} priemgetallen worden gegenereert... \n", getal);

            //For-Loop die na elk priemgetal opnieuw loopt totdat die de aangegeven hoeveelheid priemgetallen bereikt
            for (num = 1; counter <= getal; num++)
            {
                //deze for-loop deelt het huidige nummer door alles vanaf 2 tot het nummer zelf
                //een priemgetal kan alleen door zichzelf en 1 gedeeld worden
                ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    //Deze if-statement kijkt of het restgetal van de modulo 0 is.
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                {
                    Console.Write("{0} ", num);
                    counter++;
                }
            }
            Console.Write("\n");
        }
    }
}