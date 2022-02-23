using System;
namespace LaboOefeningen
{
    public class Hoofdstuk04 
    {
       public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Schoenenverkoper");
            Console.WriteLine("2. EvenOneven");
            Console.WriteLine("3. PositiefNegatiefNul");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                SchoenenVerkoper();
            }
            else if (keuze == 2) 
            {
                EvenOneven();
            }
            else if (keuze == 3) 
            {
                PositiefNegatiefNul();
            }
            else
            {
            }
        }
        public static void SchoenenVerkoper()
        {
            double prijs = 50;
            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            int aantal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Heb je een klantenkaart (ja of nee)");
            string isKlant = Console.ReadLine();
            prijs *= aantal;
            if (aantal > 2 && isKlant == "ja") 
            {
                prijs *= 0.9;
            }
            Console.WriteLine($"De prijs voor {aantal} paar schoenen is {prijs} Euro");
        }
        public static void EvenOneven()
        {
            Console.WriteLine("Geef een getal");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal % 2 == 0)
            {
                Console.WriteLine($"Het getal {getal} even");
            }
            else
            {
                Console.WriteLine($"Het getal {getal} oneven");
            }
        }
        public static void PositiefNegatiefNul()
        {
            Console.WriteLine("Geef een getal");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 0)
            {
                Console.WriteLine($"Het getal {getal} is positief");
            }
            else
            {
                if (getal < 0)
                {
                    Console.WriteLine($"Het getal {getal} is negatief");
                }
                else
                {
                    Console.WriteLine($"Het getal {getal} is nul");
                }
            } 
        }
        /*
        public static void BmiBerekenaar()
        {
            Console.WriteLine("Geef je gewicht in kg");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef je lengte in m");
            double lengte = Convert.ToDouble(Console.ReadLine());
            double bmi = gewicht / Math.Pow(lengte, 2);
            Console.WriteLine($"Je bmi is: {bmi}");
            if (bmi < 18.5)
            {
                Console.WriteLine("je hebt ondergewicht");
            }
            else
            {
                if (bmi >= 18.5 && bmi < 25)
                {
                    Console.WriteLine("je hebt een normaal gewicht");
                }
                else
                { 
                    if (bmi >= 25 && bmi < 30)
                    {
                        Console.WriteLine("je hebt overgewicht");
                    }
            else if (bmi >= 30 && bmi < 40)
            {
                Console.WriteLine("je bent zwaarlijvig");
            }
            else 
            {
                Console.WriteLine("je hebt ernstige obesitas");
            }
        }
        */
        public static void Examen()
        {
            Console.Write("Geef de uitslag van je eerste examen:");
            int uitslagExamen1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef de uitslag van je tweede examen:");
            int uitslagExamen2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef de uitslag van je derde examen:");
            int uitslagExamen3 = Convert.ToInt32(Console.ReadLine());
            double gemiddelde = (uitslagExamen1 + uitslagExamen2 + uitslagExamen3) / 3.0;
            int aantalNietGeslaagd = 0;
            if (uitslagExamen1 < 50)
            {
                aantalNietGeslaagd++;
            } 
            if (uitslagExamen2 < 50)
            {
                aantalNietGeslaagd++;
            } 
            if (uitslagExamen3 < 50)
            {
                aantalNietGeslaagd++;
            }
            if (gemiddelde > 50 && aantalNietGeslaagd < 2)
            {
                Console.WriteLine("Je bent geslaagd");
            }
            else
            {
                Console.WriteLine("Je bent niet geslaagd");
            }
        }
    }
}
