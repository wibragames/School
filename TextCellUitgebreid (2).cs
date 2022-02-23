using System;

namespace LaboOefeningen
{
    public class TextCellUitgebreid
    {

        public static string GetalVoorstellingNaarLetters(int getal)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int aantalSymbolen = alfabet.Length;
            string resultaat = "";
            int resterend = getal;
            bool laatsteKeer = false;
            while (!laatsteKeer)
            {
                if (resterend <= alfabet.Length)
                {
                    laatsteKeer = true;
                }
                int karakterIndex = (resterend - 1) % alfabet.Length;
                resultaat = alfabet[karakterIndex] + resultaat;
                resterend = (resterend - 1) / alfabet.Length;
            }
            return resultaat;
        }

        public static int LetterVoorstellingNaarGetal(string letters)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int aantalSymbolen = alfabet.Length;
            int resultaat = 0;
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                int exponent = letters.Length - i - 1;
                resultaat += (alfabet.IndexOf(letters[i]) + 1) * (int)Math.Pow(aantalSymbolen, exponent);
            }
            return resultaat;

        }

        public static void KopieerCellenZonderFormule(string[,] roosterIn, string[,] roosterUit)
        {
            for (int rij = 0; rij < roosterIn.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < roosterIn.GetLength(1); kolom++)
                {
                    if (!roosterIn[rij, kolom].StartsWith("="))
                    {
                        roosterUit[rij, kolom] = roosterIn[rij, kolom];
                    }
                }
            }
        }

        public static bool BevatNullWaarden(string[,] rooster)
        {
            for (int rij = 0; rij < rooster.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < rooster.GetLength(1); kolom++)
                {
                    if (rooster[rij, kolom] is null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static string BerekenOntbrekendeCelRechtstreeks(string formule, string[,] berekendRooster)
        {
            string[] somOnderdelen = formule.Split("+");
            for (int i = 0; i < somOnderdelen.Length; i++)
            {
                somOnderdelen[i] = WaardeVanCel(somOnderdelen[i], berekendRooster);
                if (somOnderdelen[i] is null)
                {
                    return null;
                }
            }
            int som = 0;
            for (int i = 0; i < somOnderdelen.Length; i++)
            {
                som = som + Convert.ToInt32(somOnderdelen[i]);
            }
            return som.ToString();
        }

        public static void BerekenOntbrekendeWaardenEenKeer(string[,] rooster, string[,] berekendRooster)
        {
            for (int rij = 0; rij < rooster.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < rooster.GetLength(1); kolom++)
                {
                    if (berekendRooster[rij, kolom] is null)
                    {
                        berekendRooster[rij, kolom] = BerekenOntbrekendeCelRechtstreeks(rooster[rij, kolom].Substring(1), berekendRooster);
                    }
                }
            }
        }

        public static bool IsGetal(string voorstelling)
        {   
            if (voorstelling.StartsWith("-"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            return voorstelling.StartsWith("-") ||
                   voorstelling.StartsWith("0") ||
                   voorstelling.StartsWith("1") ||
                   voorstelling.StartsWith("2") ||
                   voorstelling.StartsWith("3") ||
                   voorstelling.StartsWith("4") ||
                   voorstelling.StartsWith("5") ||
                   voorstelling.StartsWith("6") ||
                   voorstelling.StartsWith("7") ||
                   voorstelling.StartsWith("8") ||
                   voorstelling.StartsWith("9");
        }

        public static string WaardeVanCel(string waarde, string[,] rooster)
        {
            if (IsGetal(waarde))
            {   
                return waarde;
            }
            else
            {
                int getalIndex = -1;
                for(int i = 0; i < waarde.Length && getalIndex < 0; i++) {
                    if (IsGetal(waarde[i].ToString())) {
                        getalIndex = i;
                    }
                }
                int kolomIndex = LetterVoorstellingNaarGetal(waarde.Substring(0,getalIndex)) - 1;
                int rijIndex = Convert.ToInt32(waarde.Substring(getalIndex)) - 1;
                return rooster[rijIndex, kolomIndex];
            }
        }

        public static void BerekenEnToonRooster(string[,] rooster)
        {
            string[,] berekendRooster = new string[rooster.GetLength(0), rooster.GetLength(1)];
            KopieerCellenZonderFormule(rooster, berekendRooster);
            while (BevatNullWaarden(berekendRooster))
            {
                BerekenOntbrekendeWaardenEenKeer(rooster, berekendRooster);
            }
            Console.Write("".PadRight(2));
            for (int i = 0; i < rooster.GetLength(1); i++)
            {
                Console.Write("|");
                string tekstVoorstelling = GetalVoorstellingNaarLetters(i + 1).PadRight(10).Substring(0, 10);
                Console.Write(tekstVoorstelling);
            }
            Console.WriteLine("|");
            for (int rij = 0; rij < rooster.GetLength(0); rij++)
            {
                Console.Write((rij+1).ToString().PadRight(2));
                for (int kolom = 0; kolom < rooster.GetLength(1); kolom++)
                {
                    Console.Write("|");
                    Console.Write(berekendRooster[rij, kolom].PadRight(10).Substring(0, 10));
                }
                Console.WriteLine("|");
            }
        }

        public static void WijzigCel(string[,] rooster)
        {
            Console.WriteLine("Welke rij wil je wijzigen?");
            int rijIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Welke kolom wil je wijzigen?");
            int kolomIndex = LetterVoorstellingNaarGetal(Console.ReadLine()) - 1;
            Console.WriteLine("Wat wil je hier invullen?");
            rooster[rijIndex,kolomIndex] = Console.ReadLine();
        }

        public static void TextCellMain()
        {
            Console.WriteLine("Hoe veel rijen telt je spreadsheet?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoe veel kolommen telt je spreadsheet?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            string[,] rooster = new string[aantalRijen, aantalKolommen];
            for (int rij = 0; rij < aantalRijen; rij++)
            {
                for (int kolom = 0; kolom < aantalKolommen; kolom++)
                {
                    rooster[rij, kolom] = "";
                }
            }
            while (true)
            {
                BerekenEnToonRooster(rooster);
                WijzigCel(rooster);
            }
        }
    }
}