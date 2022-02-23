using System;

namespace LaboOefeningen
{
    public class Evaluatietwee
    {
        public static void Ecard()
        {
            Console.WriteLine("Wat is de algemene boodschap?");
            string boodschap = Console.ReadLine();
            Console.WriteLine("Wat is de naam van de ontvanger?");
            string naam = Console.ReadLine();
            boodschap = boodschap.Replace("NAAM", naam);
            Console.WriteLine($"{boodschap}");
        }
    }
}