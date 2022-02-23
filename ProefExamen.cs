using System;
using System.Linq;
using System.Collections.Generic;

namespace LaboOefeningen
{
    public class ProefExamen
    {
        public static int[] CumulatieveSom(int[] invoer)
        {
            int[] uitvoer = new int [invoer.Length];
            uitvoer[0] = invoer[0];
            for (int i =1; i < uitvoer.Length;i++)
            {
                uitvoer[i] = uitvoer[i - 1] + invoer[i];
            }
            return uitvoer;
        }
    }
}