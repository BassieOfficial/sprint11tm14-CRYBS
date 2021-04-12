using System;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            //oefening 12
            Console.WriteLine("Welke methode wilt u aanroepen?");
            Console.WriteLine("Typ 'btw' voor het berekenen van btw");
            Console.WriteLine("Typ 'cm' voor het omrekenen van inch naar cm");
            var methodchoice = Console.ReadLine().ToLower();
            switch (methodchoice) 
            {
                case "cm":
                    Console.WriteLine("cm methode gekozen...");
                    Console.WriteLine("Voer een getal in om te converteren van inch naar cm: ");
                    string invoer = Console.ReadLine();
                    float inch = 0;
                    var cmParse = Single.TryParse(invoer, out inch);
                    if (cmParse == true)
                    {
                        var centimeter = HoeveelCentimeter(inch);
                        Console.WriteLine($"Er gaat {centimeter} cm in {inch} inch");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Er is iets niet goed gegaan");
                        break;
                    }
                    

                case "btw":
                    Console.WriteLine("btw methode gekozen...");
                    Console.WriteLine("voer prijs in om BTW voor te berekenen: ");
                    string btwinvoer = Console.ReadLine();
                    float bedrag = 0;
                    var btwParse = Single.TryParse(btwinvoer, out bedrag);
                    if (btwParse == true)
                    {
                        var eindbedrag = HoeveelBTW(bedrag);
                        Console.WriteLine($"bedrag zonder btw: {bedrag} bedrag met 21% btw: {eindbedrag}");
                        break;
                    }
                    else {
                        Console.WriteLine("Er is iets niet goed gegaan");
                        break;
                    }
                    
                default:
                    Console.WriteLine("ongeldige invoer");
                    break;
            }
            
            Variabelen();
            

            NumericConversion();

        }
        static void Variabelen()
        {
            int getal = 1;
            UInt32 langgetal = 4294967295;
            String tekst = ("Saai stukje tekst");

            Console.WriteLine($"Het getal heeft de waarde {getal}, het langgetal heeft de waarde {langgetal} en de tekst is '{tekst}'");
        }
        static float HoeveelCentimeter(float inch)
        {
            //opdracht 10
            const float centimeterPerInch = 2.45F;
            var centimeter = inch * centimeterPerInch;
            return centimeter;
        }
        static float HoeveelBTW(float bedrag)
        {
            //opdracht 11
            const float percentage = 21;
            float btw = percentage / 100 * bedrag;
            var eindbedrag = bedrag + btw;
            return eindbedrag;
        }
        static void NumericConversion()
        {
            //opdracht 9
            double doublegetal = 8.9;
            int intgetal = Convert.ToInt32(doublegetal);

            Console.WriteLine($"Variable 1 is een double en bevat nummer: {doublegetal}, geconverteerd naar een int wordt het: {intgetal} ");
        }
        public enum btwPercentage { Verlegd = 0, Laag = 9, Hoog = 21 }

        //static float HoeveelBTW(float bedrag)
        //{
        //    float btw = bedrag / 100 * (int) Percentage;
        //    return btw;
        //}
    }
}