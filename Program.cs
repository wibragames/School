using System;

namespace LaboOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welk onderwerp kies je?");
            Console.WriteLine("1. Werken met Visual Studio Code");
            Console.WriteLine("2. Variabelen en datatypes");
            Console.WriteLine("3. Strings en hun methoden");
            Console.WriteLine("4. Beslissingen");
            Console.WriteLine("5. Loops");
            Console.WriteLine("6. Arrays");
            Console.WriteLine("7. Methoden");
            Console.WriteLine("8. Numerieke data");
            Console.WriteLine("9. Meerdimensionaal werken");
            Console.WriteLine("10. Gevorderde tekstverwerking");
            Console.WriteLine("11. evaluatie");
            Console.WriteLine("12. Textcell");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                Hoofdstuk01.Keuzemenu();
            }
            else if (keuze == 2) 
            {
                Hoofdstuk02.Keuzemenu();
            }
            else if (keuze == 3) 
            {
                Hoofdstuk03.Keuzemenu();
            }
            else if (keuze == 4)
            {
                Hoofdstuk04.Keuzemenu();
            }
            else if (keuze == 5)
            {
                Hoofdstuk05.Keuzemenu();
            }
            else if (keuze == 6)
            {
                Hoofdstuk06.Keuzemenu();
            }
            else if (keuze == 7)
            {
                Hoofdstuk07.Keuzemenu();
            }
            else if (keuze == 8)
            {
                Hoofdstuk08.Keuzemenu();
            }
            else if (keuze == 9)
            {
                Hoofdstuk09.Keuzemenu();
            }
            else if (keuze == 10)
            {
                Hoofdstuk10.Keuzemenu();
            }
            else if (keuze == 11)
            {
                int[] getallen = {13, 7, 32, 10, 7};
                int[] cumulatieveSom = ProefExamen.CumulatieveSom(getallen);
                foreach(int getal in cumulatieveSom)
                {
                    System.Console.WriteLine(getal);
                }
            }
            else if (keuze == 12)
            {
                TextCellUitgebreid.TextCellMain();
            }
            else if (keuze == 13)
            {   
                int[] getallen1 = {13, 23, 12};
                int[] getallen2 = {5, 10, 15};
                int[] Vermenigvuldiging = Examen.VermenigvuldigArrays(getallen1, getallen2);
                 foreach(int getal in Vermenigvuldiging)
                {
                    System.Console.WriteLine(getal);
                }
            }
            else if (keuze == 14)
            {
                Examen.Dobbelsteen();
            }
            // zelf aanvullen met resterende keuzemenu's voor andere onderwerpen
        }
    }
}
