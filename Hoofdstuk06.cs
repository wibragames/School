using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class Hoofdstuk06
    {
    public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. ArrayTrueFalse");
            Console.WriteLine("2. ArrayOefener1");
            Console.WriteLine("3. Boodschappenlijst");
            Console.WriteLine("4. Kerstinkopen");
            Console.WriteLine("5. Lotto");
            Console.WriteLine("10. ArrayTrueFalse_2");
            Console.WriteLine("11. IntegerIndexOf");
            Console.WriteLine("12. StringBinarySearch");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                ArrayTrueFalse();
            }
            else if (keuze == 2) 
            {
                ArrayOefener1();
            }
            else if (keuze == 3) 
            {
                Boodschappenlijst();
            }
            else if (keuze == 4) 
            {
                Kerstinkopen();
            }
            else if (keuze == 5) 
            {
                Lotto();
            }
            else if (keuze == 10) 
            {
                ArrayTrueFalse_2();
            }
            else if (keuze == 11) 
            {
                IntegerIndexOf();
            }
            else if (keuze == 12) 
            {
                StringBinarySearch();
            }
        }
        public static void ArrayTrueFalse()
        {
            Console.WriteLine("\n\nMaak een array gevuld met afwisselen true en false(lengte is 30)");
            bool[] binary = new bool[30];

            for (int i = 0; i < binary.Length; i++)
            {
                if (i % 2 == 0)
                    binary[i] = true;
                else
                    binary[i] = false;

                Console.Write(binary[i] + " ");
            }
            Console.ReadKey();
        }
        public static void ArrayTrueFalse_2()
        {
            Console.WriteLine("\n\nMaak een array gevuld met afwisselen true en false(lengte is 30)");
            bool[] trueFalseArray = new bool[30];
            bool trueFalse = true;

            for (int i = 0; i < trueFalseArray.Length; i++)
            {
                trueFalseArray[i] = trueFalse;
                trueFalse = !trueFalse;
            }
            for (int i = 0; i < trueFalseArray.Length - 1; i++)
            {
                Console.WriteLine($"{trueFalseArray[i]}, ");
            }
                Console.WriteLine($"{trueFalseArray[trueFalseArray.Length - 1]}"); 
        }
        public static void ArrayOefener1()
        {
            int[] getallen = new int[10];
            //Invoer
            Console.WriteLine("Voer 10 gehele getallen in");
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Verwerking (kan ook in lus hierboven ineens)
            int som = 0;
            int grootste = getallen[0];
            for (int i = 0; i < getallen.Length; i++)
            {
                som += getallen[i]; //som
                if (getallen[i] > grootste)
                    grootste = getallen[i];
            }
            Console.WriteLine("******");
            Console.WriteLine($"Som is {som}, Gemiddelde is {(double)som / getallen.Length}, Grootste getal is {grootste}");
            Console.WriteLine("******");

            Console.WriteLine("Geef minimum getal in?");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze > grootste)
                Console.WriteLine("Niets is groter");
            else
            {
                for (int i = 0; i < getallen.Length; i++)
                {
                    if (getallen[i] >= keuze)
                        Console.Write($"{getallen[i]} ");
                }
            }

            Console.ReadKey();
        }
        public static void Boodschappenlijst()
        {
            Console.WriteLine("We gaan de boodschappenlijst samenstellen. Hoeveel items wil je opschrijven?");

            int aantal = Convert.ToInt32(Console.ReadLine());
            string[] items = new string[aantal];

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine($"Wat is item {i + 1} op je lijst?");
                items[i] = Console.ReadLine();
            }

            Array.Sort(items);
            Console.WriteLine("Dit is je gesorteerde lijst: ");

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i]}");
            }

            Console.WriteLine("Op naar de winkel!");
            string nogWinkelen = "Ja";

            while (nogWinkelen.ToUpper() == "JA")
            {
                Console.WriteLine("Welk item heb je gekocht?");

                string item = Console.ReadLine();

                // if (Array.BinarySearch(items, item) < 0)
                if (Array.IndexOf(items, item) < 0)
                {
                    Console.WriteLine("Dit item bevindt zich niet op de lijst!");
                }
                else
                {
                    items[Array.IndexOf(items, item)] = "gekocht";
                }

                Console.WriteLine("Nog winkelen? (Ja of Nee)");
                nogWinkelen = Console.ReadLine();
            }

            Console.WriteLine("Naar huis met de boodschappen!");
            Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen: ");

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != "gekocht")
                {
                    Console.Write(items[i] + " ");
                }
            }
            Console.ReadKey();
        }

        public static void Kerstinkopen()
        {
            //Hiervoor moet je wel bovenaan deze class 'using System.Linq;' vermelden. 

            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            double budget = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel cadeautjes wil je kopen?");
            int aantal = Convert.ToInt32(Console.ReadLine());

            double[] cadeautjes = new double[aantal];

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine($"Prijs van cadeau {i + 1}?");
                cadeautjes[i] = Convert.ToDouble(Console.ReadLine());
                if (cadeautjes.Sum() > budget)
                {
                    Console.WriteLine($"Je bent al {(cadeautjes.Sum() - budget):F1} euro over het budget!");
                }
            }

            Console.WriteLine("Info over je aankopen: ");
            Console.WriteLine($"Totaal bedrag: {cadeautjes.Sum():F1} euro.");
            Console.WriteLine($"Duurste cadeau: {cadeautjes.Max():F1} euro.");
            Console.WriteLine($"Goedkoopste cadeau: {cadeautjes.Min():F1} euro.");
            Console.WriteLine($"Gemiddelde prijs: {cadeautjes.Average():F1} euro.");
            Console.ReadKey();
        }

        public static void Lotto()
        {
            int[] lottoFormulier = new int[6];
            
            // Ingeven van de lotto getallen
            Console.WriteLine("Geef je lotto getallen (getallen moeten tussen 1 en 42 liggen)");
            int i;
            
            // Vergeet niet dat de beginindex van een array 0 is
            for (i = 0; i < lottoFormulier.Length; i++)
            {
                Console.WriteLine("Geef lotto nummer " + (i + 1).ToString());
                lottoFormulier[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] lottoTrekking = new int[6];
            
            // Initialisatie van de trekking
            // Flowgorithm eist dat je de array eerst initialiseert, in c# wordt de array opgevuld met de default waarde van het type.
            for (i = 0; i < lottoTrekking.Length; i++)
            {
                lottoTrekking[i] = 0;
            }
            Random random = new Random();
            int lottoGetal;
            
            for (i = 0; i < lottoTrekking.Length; i++)
            {
                do
                {
                    lottoGetal = random.Next(42) + 1;
                }
                while (Array.IndexOf(lottoTrekking, lottoGetal) >= 0);
                lottoTrekking[i] = lottoGetal;
            }
            
            int aantalJuisteGetallen = 0;
            for (i = 0; i <= 5; i++)
            {
                if (Array.IndexOf(lottoTrekking, lottoFormulier[i]) >= 0)
                {
                    aantalJuisteGetallen += 1;
                }
            }

            int gewonnenBedrag = 0;
            if (aantalJuisteGetallen == 3)
            {
                gewonnenBedrag = 10;
            }
            else if (aantalJuisteGetallen == 4)
            {
                gewonnenBedrag = 1000; 
            }
            else if (aantalJuisteGetallen == 5)
            {
                gewonnenBedrag = 100000; 
            }
            else if (aantalJuisteGetallen == 6)
            {
                gewonnenBedrag = 10000000; 
            }
            else
            {
            }

            Array.Sort(lottoFormulier);
            Array.Sort(lottoTrekking);

            Console.WriteLine("Je gekozen cijfers zijn:");
            for (i = 0; i < lottoFormulier.Length; i++)
            {
                Console.Write($"{lottoFormulier[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("De trekking cijfers zijn:");
            for (i = 0; i < lottoTrekking.Length; i++)
            {
                Console.Write($"{lottoTrekking[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Je hebt {gewonnenBedrag} Euro gewonnen");
            Console.ReadKey();
        }
        public static void IntegerIndexOf()
        {
            int[] waardes = new int[10];

            int i;
            int index;
            Console.WriteLine("Geef 10 willekeurige gehele getallen");
            for (i = 0; i < waardes.Length; i++)
            {
                waardes[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Welke geheel getal wil je zoeken?");
            int zoekWaarde = Convert.ToInt32(Console.ReadLine());

            i = 0;
            index = -1;
            do
            {
                if (waardes[i] ==  zoekWaarde)
                {
                    index = i;
                }
                i++;
            } while (i < waardes.Length && index == -1); 
            if (index == -1)
            {
                Console.WriteLine($"Je zocht {zoekWaarde}, jammer die is niet gevonden");
            }
            else
            {
                Console.WriteLine($"Je zocht {zoekWaarde}, die is gevonden op index {index}");
            }
            Console.ReadKey();
        }
        public static void StringBinarySearch()
        {
            string[] autoMerken = { "Citroen", "Mercedes", "Peugeot", "BMW", "Toyota", "AstonMartin", "Ferrari", "Opel", "Lexus", "Wartburg" };

            int beginIndex = 0;
            int eindIndex = autoMerken.Length;
            int middenIndex;
            int index = -1;

            Console.WriteLine("Welke automerk wil U zoeken?");
            string zoekWaarde = Console.ReadLine();

            Array.Sort(autoMerken);
            while (beginIndex <= eindIndex)
            {
                middenIndex = beginIndex + (eindIndex - beginIndex) / 2;
                if (autoMerken[middenIndex].CompareTo(zoekWaarde) < 0)
                {
                    beginIndex = middenIndex + 1;
                }
                else if (autoMerken[middenIndex].CompareTo(zoekWaarde) > 0)
                {
                    eindIndex = middenIndex - 1;
                }
                else
                {
                    index = middenIndex;
                    beginIndex = eindIndex + 1;
                }
            }
            if (index == -1)
            {
                Console.WriteLine($"Je zocht {zoekWaarde}, jammer die is niet gevonden");
            }
            else
            {
                Console.WriteLine($"Je zocht {zoekWaarde}, die is gevonden op index {index}");
            }
            Console.ReadKey();
        }
    }
}
    