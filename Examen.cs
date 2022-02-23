using System;
using System.Linq;
using System.Collections.Generic;

namespace LaboOefeningen
{
    public class Examen
    {
        public static int[] VermenigvuldigArrays(int[] invoer1, int[] invoer2)
        {
            int[] uitvoer = new int [invoer1.Length];
            for (int i = 0; i < uitvoer.Length; i++)
            {
                uitvoer[i] = invoer1[i] + invoer2[i];
            }
            return uitvoer;
        }
        public static void Dobbelsteen()
        {
            Console.WriteLine("Hoeveel zijden heeft de dobbelsteen?");
            int aantalZijden = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            
            string stop = "";

            do 
            {
                Console.WriteLine($"{random.Next(aantalZijden)} !");
                stop = Console.ReadLine();
            } while (stop != "STOP");   
        }
    }
    
}