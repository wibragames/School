using System;
namespace LaboOefeningen
{
    public class Hoofdstuk05 
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. CountDown");
            Console.WriteLine("2. Wachtwoord");
            Console.WriteLine("3. Feestje");
            Console.WriteLine("4. RNATranscriptie");
            Console.WriteLine("5. VanMin100Tot100");
            Console.WriteLine("6. EenTafel");
            Console.WriteLine("7. PriemChecker");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                CountDown();
            }
            else if (keuze == 2) 
            {
                Wachtwoord();
            }
            else if (keuze == 3) 
            {
                Feestje();
            }
            else if (keuze == 4) 
            {
                RNATranscriptie();
            }
            else if (keuze == 5) 
            {
                VanMin100Tot100();
            }
            else if (keuze == 6) 
            {
                EenTafel();
            }
            else if (keuze == 7) 
            {
                PriemChecker();
            }
        }
        
        public static void CountDown() 
        {
            Console.WriteLine("De flowchart is gegeven. Je kan deze laten omzetten door Flowgorithm.");
        }
        public static void Wachtwoord() 
        {
            Console.WriteLine("De flowchart is gegeven. Je kan deze laten omzetten door Flowgorithm.");
        }
        public static void Feestje() 
        {
            int aantalPersonen = 0;
            string personen = "";
            string antwoord;
            do 
            {
                Console.Write("Wil je een volgende persoon inschrijven (ja of nee) ");
                antwoord = Console.ReadLine();
                if (antwoord == "ja") 
                {
                    Console.Write("Geef de naam: ");
                    string persoon = Console.ReadLine();
                    if (aantalPersonen > 0) 
                    {
                        personen += " ";
                    }
                    aantalPersonen++;
                    personen += persoon;
                }
            } while (antwoord != "nee" && aantalPersonen < 20);
            Console.WriteLine($"Lijst van aanwezigen: {personen}");
            Console.WriteLine($"Er zijn {aantalPersonen} personen aanwezig.");
        }
        public static void RNATranscriptie()
        {
            string input = "", DNA = "", RNA = "";
            do
            {
                Console.WriteLine("Voer G,C,T of A in");
                input = Console.ReadLine();
                switch (input)
                {
                case "G":
                    DNA += "G";
                    RNA += "C";
                    break;
                case "C":
                    DNA += "C";
                    RNA += "G";
                    break;
                case "T":
                    DNA += "T";
                    RNA += "A";
                    break;
                case "A":
                    DNA += "A";
                    RNA += "U";
                    break;
                default:
                    input = "ongeldig"; //wordt genegeerd
                break;
                }
            } while (input != "");
            Console.WriteLine($"Je resultaat is: {RNA}");
            Console.ReadKey();
        }
        public static void VanMin100Tot100() 
        {
            for (int i = -100; i <= 100; i = i+2) 
            {
                Console.WriteLine(i);
            }
        }
        public static void EenTafel() {
            Console.WriteLine("Van welk getal wil je de tafel van vermenigvuldiging zien?");
            int getal = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}x{getal} = {getal * i}");
            }
        }
        public static void PriemChecker()
        {
            Console.WriteLine("Geef een getal");
            int input = Convert.ToInt32(Console.ReadLine());
            int delerTeller = 0;
            for (int i = 2; i <= input; i++)
            {
                if (input % i == 0)
                {
                    delerTeller++;
                }
            }
            if (delerTeller == 1)
            {
                Console.WriteLine("Het getal is een priemgetal!");
            }
            else
            {
                Console.WriteLine("Het getal is geen priemgetal!");
            }
        }
    }
 }