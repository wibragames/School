using System;
using System.Windows.Input;

namespace LaboOefeningen
{
    public class Hoofdstuk10
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Som Van Cijfers");
            Console.WriteLine("2. Centraal Aligneren Tekst");
            Console.WriteLine("3. Interpolatie Formateren");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                SomVanGetallen();
            }
            if (keuze == 2) 
            {
                CentraalAlignerenTekst();
            }
            if (keuze == 3) 
            {
                // Geen nieuwe methodes!!!!
            }
        }

        public static void SomVanGetallen() 
        {
            Console.WriteLine("Gelieve getallen gescheiden door ';'  in te geven");
            string getallenTekst = Console.ReadLine();
            string[] getallenGesplitst = getallenTekst.Split(";");
            int som = 0;
            for (int i = 0; i < getallenGesplitst.Length; i++)
            {
                som += Convert.ToInt32(getallenGesplitst[i]);
            }
            string getallenSom = string.Join("+", getallenGesplitst);
            Console.WriteLine($"{getallenSom} = {som}");
        }
        public static void CentraalAlignerenTekst() 
        {
            Console.WriteLine("Geef een tekst in: ");
            string tekst = Console.ReadLine();
            Console.WriteLine($"Geef de gewenste lengte van de tekst op, die moet minimaal {tekst.Length} zijn");
            int gewensteLengte = Convert.ToInt32(Console.ReadLine());
            while (gewensteLengte <= tekst.Length)
            {
                Console.WriteLine($"Lengte moet minimaal {tekst.Length} zijn, geef de lengte opnieuw in!");
                gewensteLengte = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Geef het 'padding karakter':");
            string padding = Console.ReadLine();
            Console.WriteLine(CentraalAligneren(tekst, gewensteLengte, padding[0]));
        }
        public static string CentraalAligneren(string tekst, int lengte, char padding)
        {
            return (tekst.PadLeft((lengte - tekst.Length) / 2 + (lengte - tekst.Length) % 2 
            + tekst.Length, padding)).PadRight(lengte, padding);
        }
    }
}