using System;

namespace LaboOefeningen
{
    public class Evaluatiedrie
    {
        public static void AanbevolenHuisdier()
        {
            int hond = 0;
            int kat = 0;
            int vis = 0;
            Console.WriteLine("Ga je vaak op reis?");
            string answer1 = Console.ReadLine();
            if (answer1 == "ja")
            {
                hond--;
            }
            Console.WriteLine("Heb je graag veel interactie met je huisdier?");
            string answer2 = Console.ReadLine();
            if (answer2 == "ja")
            {
                hond++;
                vis--;
            }
            else if (answer2 == "een beetje")
            {
                kat++;
                vis++;
            }
            else
            {
                hond--;
                vis++;
            }
            Console.WriteLine("Heb je veel belang aan een propere vloer?");
            string answer3 = Console.ReadLine();
            if (answer3 == "ja")
            {
                hond--;
                kat--;
            }
            else if (answer3 == "een beetje")
            {
                hond--;
            }
            else 
            {
            }
            Console.WriteLine("de scores zijn:");
            Console.WriteLine($"hond: {hond}");
            Console.WriteLine($"kat: {kat}");
            Console.WriteLine($"vis: {vis}");
        }
        public static void HalloweenBegroeter()
        {
            Console.WriteLine("Hallo, als wat ben je verkleed");
            string answer = Console.ReadLine();
            int aantal = 1;
            int aantalChocolade=0;
            int aantalDrop=0;
            int aantalZuurtjes=0;
            do
            {
                
                if (aantal == 1|| aantal == 4)
                {
                    Console.WriteLine($"Dag {answer}, jij mag chocolade nemen.");
                    aantalChocolade++;
                    
                }
                else if (aantal == 2|| aantal ==5)
                {
                    Console.WriteLine($"Dag {answer}, jij mag drop nemen.");
                    aantalDrop++;
                }
                else if (aantal == 3|| aantal == 6)
                {
                    Console.WriteLine($"Dag {answer}, jij mag zuurtjes nemen.");
                    aantalZuurtjes++;
                }
                Console.WriteLine("Hallo, als wat ben je verkleed");
                aantal++;
                answer = answer = Console.ReadLine();
            } while (answer != "niemand");
            Console.WriteLine($"Programma wordt nu afgesloten. Er is {aantalChocolade} keer chocolade uitgedeeld, {aantalDrop} keer drop, {aantalZuurtjes} keer zuurtjes.");            
        }
    } 
}