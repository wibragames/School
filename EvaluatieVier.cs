using System;
using System.Linq;
using System.Collections.Generic;

namespace LaboOefeningen
{
    public class EvaluatieVier
    {
        public static string[] naamFilter(string[] namen)
        {
            /*
            int aantalGeldig = 0;
            for (int i = 0; i < namen.Length; i++)
            {
                if (GeldigeNaam(namen[i]))
                {
                    aantalGeldig++;
                }
            }
            string[] geldigeNamen = new string[aantalGeldig];
            */
            //int j = 0;
            List<string> geldigeNamen = new List<string>();
            for (int i = 0; i < namen.Length; i++)
            {
                if (GeldigeNaam(namen[i]))
                {
                    geldigeNamen.Add(namen[i]);
                }
            }
            return geldigeNamen.ToArray();
        }
        public static bool GeldigeNaam(string naam)
        {
            string[] klinkers = {"a", "e", "i", "o", "u"};
            if (Array.IndexOf(klinkers,naam.Substring(0,1).ToLower()) >=0)
            {
                return false;
            }
            else if (naam.Length > 5)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public static string[] MuziekOefening()
        {
            string[] noten = {"do", "re", "mi", "fa", "sol", "la", "si"};
            Random random = new Random();
            int aantalNoten = random.Next(20,121);
            string[] oeffening = new string[aantalNoten];
            for (int i = 0; i < oeffening.Length; i++)
            {
                oeffening[i] = $"{noten[random.Next(7)]}{random.Next(3, 6)}";
            }
            return oeffening;
        }
    }
}