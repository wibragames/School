using System;
namespace LaboOefeningen
{
    public class Hoofdstuk01 
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Mijn eerste programma");
            Console.WriteLine("2. Rommelzin");
            Console.WriteLine("3. Gekleurde rommelzin");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                MijnEersteProgramma();
            }
            else if (keuze == 2) 
            {
                Rommelzin();
            }
            else 
            {
                GekleurdeRommelzin();
            }
        }
        public static void MijnEersteProgramma()
        {
            Console.WriteLine("Dit is MijnEersteProgramma");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Geef je naam:");
            string naam = Console.ReadLine();
            Console.WriteLine("Welkom " + naam);
        }
        public static void Rommelzin()
        {
            Console.WriteLine("Dit is Rommelzin");
            Console.WriteLine("----------------");
            Console.WriteLine("Wat is je favoriete kleur?");
            string kleur = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete eten");
            string eten = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete auto");
            string auto = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete film");
            string film = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete boek");
            string boek = Console.ReadLine();
            Console.WriteLine("Je favourite kleur is " + eten + 
                              ", je eet graag " + auto +
                              ", je lievelingsfilm is " + boek +
                              ", favourite boek is " + film);
        }
        public static void GekleurdeRommelzin()
        {
            Console.WriteLine("Dit is GekleurdeRommelzin");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wat is je favoriete kleur?");
            string kleur = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wat is je favoriete eten");
            string eten = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wat is je favoriete auto");
            string auto = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Wat is je favoriete film");
            string film = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete boek");
            string boek = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Je favourite kleur is " + eten + 
                              ", je eet graag " + auto +
                              ", je lievelingsfilm is " + boek +
                              ", favourite boek is " + film);
        }
    }
}  
