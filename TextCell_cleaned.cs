using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class TextCellRevisioned
    {
        private static string GetalVoorstellingNaarLetter(int getal) => $"{(char)(getal+64)}";

        private static int LetterVoorstellingNaarGetal(string letters)
        {
            string alfabet = string.Join("", Enumerable.Range((int)'A', (int)'Z'+1).Select(i => (char)i));

            int output = 0;
            for(int i = letters.Length-1; i >= 0; i--)
            {
                int exponent = (letters.Length-1)-i;
                output += ((alfabet.IndexOf(letters[i])+1) * (int)Math.Pow(letters.Length, exponent));
            }

            return output;
        }


        private static void KopieerCellenZonderFormulen(string[,] input, string[,] output)
        {
            for(int y = 0; y < input.GetLength(0); y++)
                for(int x = 0; x < input.GetLength(1); x++)
                    if(!input[y, x].StartsWith("="))
                        output[y, x] = input[y, x];
        }

        private static bool BevatNullWaarden(string[,] input)
        {
            for(int y = 0; y < input.GetLength(0); y++)
                for(int x = 0; x < input.GetLength(1); x++)
                    if(input[y, x] is null) 
                        return true;

            return false;
        }

        private static bool IsGetal(string input) => new System.Text.RegularExpressions.Regex("^[0-9]").IsMatch(input);

        private static string BerekenOntbrekendeCelRechtstreeks(string formule, string[,] output)
        {
            string[] formuleOnderdelen = formule.Split("+");
            for(int i = 0; i < formuleOnderdelen.Length; i++)
            {
                if((formuleOnderdelen[i] = WaardeVanCel(formuleOnderdelen[i], output)) is null)
                    return null;
            }

            int som = 0;
            for(int i = 0; i < formuleOnderdelen.Length; i++)
                som += Convert.ToInt32(formuleOnderdelen[i]);
            
            return som.ToString();
        }

        private static string WaardeVanCel(string input, string[,] output)
        {
            if(IsGetal(input)) 
                return input;

            int getalIndex = -1;
            for(int i = 0; i < input.Length && getalIndex < 0; i++)
                if(IsGetal($"{input[i]}"))
                    getalIndex = i;
            Console.WriteLine($"here {(LetterVoorstellingNaarGetal(input.Substring(0, getalIndex))-1)}");
            return output[
                Convert.ToInt32(input.Substring(getalIndex))-1, 
                LetterVoorstellingNaarGetal(input.Substring(0, getalIndex))-1
            ];
        }

        private static void BerekenOntbrekendeWaardeEenKeer(string[,] input, string[,] output)
        {
            for(int y = 0; y < input.GetLength(0); y++)
                for(int x = 0; x < input.GetLength(1); x++)
                    if(output[y, x] is null)
                        output[y, x] = BerekenOntbrekendeCelRechtstreeks(input[y, x].Substring(1), output);
        }

        private static void BerekenEnToonRooster(string[,] huidigeRooster)
        {
            string[,] berekendRooster = new string[huidigeRooster.GetLength(0), huidigeRooster.GetLength(1)];
            KopieerCellenZonderFormulen(huidigeRooster, berekendRooster);

            while(BevatNullWaarden(berekendRooster)) 
                BerekenOntbrekendeWaardeEenKeer(huidigeRooster, berekendRooster);
    
            // Header
            Console.Write("".PadRight(2));
            for(int i = 0; i <  huidigeRooster.GetLength(1); i++)
            {
                Console.Write("|");
                string tekstVoorstelling = GetalVoorstellingNaarLetter(i + 1).PadRight(10).Substring(0, 10);
                Console.Write(tekstVoorstelling);
            }
            Console.WriteLine("|");
            
            //Body
            for(int y = 0; y < huidigeRooster.GetLength(0); y++)
            {
                Console.Write($"{y+1}".PadRight(2));
                for(int x = 0; x < huidigeRooster.GetLength(1); x++)
                {
                    Console.Write("|");
                    Console.Write(berekendRooster[y, x].PadRight(10).Substring(0, 10));
                }
                Console.WriteLine("|");
            }
        }

        private static void WijzigCel(string[,] rooster)
        {            
            Console.WriteLine("Welke rij wil je wijzigen?");
            string ingetypt = Console.ReadLine();
            
            if (ingetypt == "bewaar")
            {
                Console.WriteLine("Hoe heet de file?");
                string filenaam = Console.ReadLine();
                 
            }
            else 
            {
                int rijIndex = LetterVoorstellingNaarGetal(ingetypt) - 1;
                Console.WriteLine("Welke kolom wil je wijzigen?");
                int kolomIndex = LetterVoorstellingNaarGetal(Console.ReadLine()) - 1;
                Console.WriteLine((rijIndex, kolomIndex));
                Console.WriteLine("Wat wil je hier invullen?");
                rooster[rijIndex, kolomIndex] = Console.ReadLine();
            }
            
        }

        public static void TextCellMain()
        {
            Console.WriteLine("Hoe veel rijen telt je spreadsheet?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoe veel kollomen telt je spreadsheet?");
            int aantalKollomen = Convert.ToInt32(Console.ReadLine());
            
            string[,] rooster = new string[aantalRijen, aantalKollomen];
            for(int y = 0; y < rooster.GetLength(0); y++)
                for(int x = 0; x < rooster.GetLength(1); x++)
                    rooster[y, x] = "";

            while(true)
            {
                BerekenEnToonRooster(rooster);
                WijzigCel(rooster);
            }
        }
    }
}