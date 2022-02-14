using System;

namespace LoginVAlidation
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            // kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            // siis konsoolis kuvatakse "Tere tulemast"
            // muu konsoolis kuvatakse "Vale kasutajatunnus vüi salasõna. Proovi uuesti."
            // kolm katset

           int i = 0;
            
            while(i < 3)
            {
            Console.WriteLine("Sisesta kasutajatunnus:");
        
            string userName = Console.ReadLine();
        
            Console.WriteLine("Sisesta salasõna");
        
            string userPassword = Console.ReadLine();
                
                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;

                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. {3 - i} katset jäänud, palun proovige uuesti");
                }
            }

            Console.WriteLine("Kena päeva!");

                


            
            
        }
        
    }
}
        