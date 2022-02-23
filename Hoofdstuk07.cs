using System;

namespace LaboOefeningen
{
    public class Hoofdstuk07
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Opwarmers");
            Console.WriteLine("2. E-mailadresGenerator");
            Console.WriteLine("3. E-mailadresGenerator_MetArray");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                Opwarmers();
            }
            if (keuze == 2) 
            {
                EmailadresGenerator();
            }
            if (keuze == 3) 
            {
                EmailadresGenerator_MetArray();
            }
        }
        public static void Opwarmers()
        {
            double diameter;
            Console.Write("Geef de diameter van de cirkel: ");
            diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De straal van de cirkel is {BerekenStraal(diameter):f3}");
            Console.WriteLine($"De omtrek van de cirkel is {BerekenOmtrek(diameter):f3}");
            Console.WriteLine($"De oppervlakte van de cirkel is {BerekenOppervlakte(diameter):f3}");
            double getal1, getal2;
            Console.WriteLine("Geef twee getallen: ");
            getal1 = Convert.ToDouble(Console.ReadLine());
            getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Het grootste getal van {getal1} en {getal2} is {Maximum(getal1, getal2)}");
            int getal;
            Console.WriteLine("Geef een geheel getal: ");
            getal = Convert.ToInt32(Console.ReadLine());
            if (IsEven(getal))
            {
                Console.WriteLine($"Getal {getal} is een even getal");
            }
            else
            {
                Console.WriteLine($"Getal {getal} is een oneven getal");
            }
            Console.WriteLine($"De reeks van oneven getallen van 1 tot {getal} is:");
            ToonOnevenNummers(getal);
            Console.ReadKey();
        }
        public static double BerekenStraal(double diameter)
        {
            return diameter / 2;
        }
        public static double BerekenOmtrek(double diameter)
        {
            return diameter * Math.PI;
        }
        public static double BerekenOppervlakte(double diameter)
        {
            return BerekenStraal(diameter) * BerekenStraal(diameter) * Math.PI;
        }
        public static double Maximum(double getal1, double getal2)
        {
            if (getal1 >= getal2)
            {
                return getal1;
            }
            else    
            {
                return getal2;
            }
        }
        public static bool IsEven(int getal)
        {
            if (getal % 2 == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ToonOnevenNummers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        public static void EmailadresGenerator()
        {
            string voornaam;
            string achternaam;
            bool isStudent;
            string student;
            
            Console.Write("Geef voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("Geef achternaam: ");
            achternaam = Console.ReadLine();
            Console.Write("student (false/true):");
            isStudent = Convert.ToBoolean(Console.ReadLine());
            voornaam = StringToLower(voornaam);
            achternaam = StringToLower(achternaam);
            achternaam = StringTrim(achternaam);
            if (isStudent)
            {
                student = ".student";
            }
            else
            {
                student = "";
            }
            Console.WriteLine("email: " + voornaam + "." + achternaam + student + "@ap.be");
            Console.ReadKey();
        }
            
        public static string StringToLower(string tekst)
        {
            string geconverteerdeTekst;
            
            geconverteerdeTekst = "";
            int i;
            int karakter;
            
            karakter = 0;
            for (i = 0; i <= tekst.Length - 1; i++)
            {
                karakter = (int) tekst[i];
                if (karakter >= (int)'A' && karakter <= (int)'Z')
                {
                    karakter = karakter + ((int)'a' - (int)'A');
                }
                geconverteerdeTekst = geconverteerdeTekst + (char) karakter;
            }
            
            return geconverteerdeTekst;
        }
        
        public static string StringTrim(string tekst)
        {
            string geconverteerdeTekst;
            
            geconverteerdeTekst = "";
            int i;
            int karakter;
            
            karakter = 0;
            for (i = 0; i <= tekst.Length - 1; i++)
            {
                karakter = (int) tekst[i];
                if (karakter != (int)' ')
                {
                    geconverteerdeTekst = geconverteerdeTekst + (char) karakter;
                }
            }
            
            return geconverteerdeTekst;
        }
        public static void EmailadresGenerator_MetArray()
        {
            string voornaam;
            string achternaam;
            bool isStudent;
            string student;
            
            Console.Write("Geef voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("Geef achternaam: ");
            achternaam = Console.ReadLine();
            Console.Write("student (false/true):");
            isStudent = Convert.ToBoolean(Console.ReadLine());
            voornaam = StringToLower_MetArray(voornaam);
            achternaam = StringToLower_MetArray(achternaam);
            achternaam = StringTrim_MetArray(achternaam);
            if (isStudent)
            {
                student = ".student";
            }
            else
            {
                student = "";
            }
            Console.WriteLine("email: " + voornaam + "." + achternaam + student + "@ap.be");
            Console.ReadKey();
        }
            
        public static string StringToLower_MetArray(string tekst)
        {
            char[] tekst_Array = tekst.ToCharArray();
            for (int i = 0; i <= tekst_Array.Length - 1; i++)
            {
                tekst_Array[i] = Char.ToLower(tekst_Array[i]);
            }
            
            return new string(tekst_Array);
        }
        
        public static string StringTrim_MetArray(string tekst)
        {
            char[] tekst_Array = tekst.ToCharArray();
            
            // Bepaal de grootte van de geconverteerde tekst array
            int j = 0;

            for (int i = 0; i <= tekst_Array.Length - 1; i++)
            {
                if (tekst_Array[i] != ' ')
                {
                    j += 1;
                }
            }

            char[] geconverteerdeTekst_Array = new char[j];
            j = 0;
            for (int i = 0; i <= tekst_Array.Length - 1; i++)
            {
                if (tekst_Array[i] != ' ')
                {
                    geconverteerdeTekst_Array[j] = tekst_Array[i];
                    j = j + 1;
                }
            }
            return new string(geconverteerdeTekst_Array);
        }
    }
}