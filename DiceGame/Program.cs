using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //" Mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid;
            // programm kontrollib, kumb mängija viskas rohkem
            // mängija, kes viskab rohkem, ongi võitja
            // täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();
            int cpuRandom;
            int userRandom;

            int cpuScore = 0;
            int userScore = 0;

            
            for (int i = 0; i < 3; i++)
            {
                cpuRandom = rnd.Next(1, 7);
                 userRandom = rnd.Next(1, 7); 

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                cpuScore += cpuRandom;
                userScore += userRandom;

                
            }
            Console.WriteLine($"Arvuti skoor on {cpuScore}. Kasutaja skoor on {userScore}.");
            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
              
                
            }
            else if(cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
               
                
            }
            else
            {
                Console.WriteLine("Viik");
            }



        }
    }
}
