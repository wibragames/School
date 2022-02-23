using System;
using System.Threading;

namespace LaboOefeningen
{
    class ConwayGameOfLife{
        enum Status{levend,dood}

        public static void ConwayGameOfLifeMain(){
            Console.WriteLine("Hoeveel cellen wil je?");
            int cellen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel generaties wil je zien ?");
            int generaties = Convert.ToInt32(Console.ReadLine());
            Status[,] veld = new Status[cellen,cellen];
            Random random = new Random();
            for (int i = 0; i < cellen; i++)/*Veld pvullen*/
            {
                for (int j = 0; j < cellen; j++)
                {
                    int ranGetal = random.Next(0,2);
                    veld[i,j]=(Status) ranGetal;  
                }
            }
            for (int generatie = 0; generatie < generaties; generatie++)/*regels toepassen voor elke cel*/
            {
                for (int i = 0; i < cellen; i++)
                {
                    for (int j = 0; j < cellen; j++)
                    {
                        int aantalNeighbors = GetNeighbors(i,j,cellen,veld);
                        if(veld[i,j]==Status.levend){
                            if(aantalNeighbors < 2 || aantalNeighbors > 3){
                                veld[i,j]=Status.dood;
                             }
                        }else{
                            if(aantalNeighbors==3){
                                veld[i,j]=Status.levend;
                             }
                         }
                    }
                }
                
                for (int i = 0; i < cellen; i++)
                {
                    for (int j = 0; j < cellen; j++)
                    {
                        if(veld[i,j]==Status.levend){
                            Console.Write("O");
                        }else{
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.Clear();
            }

        }
		
		
		public static bool IsGeldig(int rij,int kol,int maxIndex){
            if((0 <= rij  && rij <= maxIndex)  && (0 <= kol && kol <= maxIndex)){
                return true;
            }
            return false;
        }
		
		
		
        private static int GetNeighbors(int celRij,int celKol,int cellen,Status[,] veld){
            int aantalLevend=0;
            int[,] mogelijkePos = {{0,1},{0,-1},{1,0},{-1,0},{1,1},{-1,1},{1,-1},{-1,-1}};
            for (int i = 0; i < 8; i++)
            {
                if(IsGeldig(celRij+mogelijkePos[i,0],celKol+mogelijkePos[i,1],cellen-1) && veld[celRij+mogelijkePos[i,0],celKol+mogelijkePos[i,1]] == Status.levend){
                    aantalLevend++;
                }
            }
            return aantalLevend;
        }
    }
}