using System;
namespace ConsoleAppBoucle_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double cout = 150;        
            double recetteSemaine = 31;
            double totalRecettes = 0;
            int semaines = 0;

            while (totalRecettes < cout)
            {
                totalRecettes = totalRecettes + recetteSemaine;
                recetteSemaine = recetteSemaine * 0.8;   
                semaines = semaines + 1;
            }

            Console.WriteLine("Le film est bénéficiaire au bout de " + semaines + " semaines.");
        }
    }
}
