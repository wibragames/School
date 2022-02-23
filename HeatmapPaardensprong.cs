using System;
using System.Threading;

namespace LaboOefeningen
{
    public class HeatmapPaardensprong
    {
       public static void Keuzemenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. HeatmapPaardensprongMain");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                HeatmapPaardensprongMain();
            }
        }
    public static void HeatmapPaardensprongMain()
        {
            Random random = new Random();
            int[,] board = new int[8, 8];

            Console.WriteLine("Op welke plaats sta je? (A1 - H8");
            char[] huidigeLocatie = Console.ReadLine().ToCharArray();
            int XPosition = huidigeLocatie[0] - 'A', YPosition = int.Parse(huidigeLocatie[1].ToString());
 

            Console.WriteLine("Hoe vaak wil je je paard laten springen?");
            int AmountOfJumps = int.Parse(Console.ReadLine());

            for (int x = 0; x < AmountOfJumps; x++)
            {
                int xJump, yJump;

                do
                {
                    xJump = random.Next(100) > 50 ? (random.Next(50) > 25 ? 2 : -2) : (random.Next(50) > 25 ? 1 : -1);
                    yJump = Math.Abs(xJump) == 2 ? (random.Next(50) > 25 ? 1 : -1) : (random.Next(50) > 25 ? 2 : -2);
                } while ((XPosition + xJump) < 0 || (XPosition + xJump) > 7 || (YPosition + yJump) < 0 || (YPosition + yJump) > 7);

                XPosition += xJump;
                YPosition += yJump;
                board[YPosition, XPosition]++;
            }

            for(int y = 0; y < board.GetLength(0); y++) {
                for(int x = 0; x < board.GetLength(1); x++) {
                    Console.Write($"{board[y, x]} ");
                }
                Console.WriteLine();
            }
        }
    }
}