using System;

namespace LaboOefeningen
{
    public class Hoofdstuk09
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Som Rijen");
            Console.WriteLine("2. Som kolommen");
            Console.WriteLine("3. Pixels");
            Console.WriteLine("4. Conway's Game Of Life ");
            Console.WriteLine("5. HeatmapPaardensprong");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                SomPerRij();
            }
            if (keuze == 2) 
            {
                SomPerKolom();
            }
            if (keuze == 3) 
            {
                Pixels();
            }
            if (keuze == 4) 
            {
                ConwayGameOfLife.ConwayGameOfLifeMain();
            }
            if (keuze == 5) 
            {
                HeatmapPaardensprong.HeatmapPaardensprongMain();
            }
        }

        public static void SomPerRij()
        {
            Console.WriteLine($" Hoe veel rijen telt je array?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Hoe veel kolommen telt je array?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            int[,] getallen = new int[aantalRijen, aantalKolommen];
            for (int j = 0; j < getallen.GetLength(1); j++)
            {
                for (int i = 0; i < getallen.GetLength(0); i++)
                {
                    Console.WriteLine($"Waarde voor rij {i + 1}, kolom {j + 1}:");
                    getallen[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sommen per rij:");
            for (int i = 0; i < getallen.GetLength(0); i++)
            {
                int som = 0;
                for (int j = 0; j < getallen.GetLength(1); j++)
                {
                    som += getallen[i, j];
                }
                Console.WriteLine(som);
            }
        }
        public static void SomPerKolom()
        {
            Console.WriteLine($" Hoe veel rijen telt je array?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Hoe veel kolommen telt je array?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            int[,] getallen = new int[aantalRijen, aantalKolommen];
            for (int i = 0; i < getallen.GetLength(0); i++)
            {
                for (int j = 0; j < getallen.GetLength(1); j++)
                {
                    Console.WriteLine($"Waarde voor rij {i + 1}, kolom {j + 1}:");
                    getallen[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sommen per kolom:");
            for (int j = 0; j < getallen.GetLength(1); j++)
            {
                int som = 0;
                for (int i = 0; i < getallen.GetLength(0); i++)
                {
                    som += getallen[i, j];
                }
                Console.WriteLine(som);
            }
        }
        public static void Pixels()
        {
            ConsoleColor[] kleuren = (ConsoleColor[]) Enum.GetValues(typeof(ConsoleColor));
            Console.WriteLine($" Hoe veel rijen telt je canvas?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Hoe veel kolommen telt je canvas?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            ConsoleColor[,] canvas = new ConsoleColor[aantalRijen, aantalKolommen];
            int keuze = 0;
            while (keuze != 3)
            {
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1. Een pixel kleuren?");
                Console.WriteLine("2. Afbeelding tonen?");
                Console.WriteLine("3. Stoppen?");
                keuze = Convert.ToInt32(Console.ReadLine());
                if (keuze == 1)
                {
                    Console.WriteLine("Wat is de rij-index van de pixel (begin van af 0?");
                    int indexX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wat is de kolom-index van de pixel (begin van af 0?");
                    int indexY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Welke kleur wil je gebruiken?");
                    for (int i = 0; i < kleuren.Length; i++)
                    {
                        Console.WriteLine($"{i}: {kleuren[i]}");
                    }
                    canvas[indexX, indexY] = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
                }
                else if (keuze == 2)
                {
                    ShowPixels(canvas);
                }
            }
        }

        public static void ShowPixels(ConsoleColor[,] pixelColors)
        {
            Console.Clear();
            for (int i = 0; i < pixelColors.GetLength(0); i++)
            {
                for (int j = 0; j < pixelColors.GetLength(1); j++)
                {
                    Console.BackgroundColor = pixelColors[i, j];
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
