using System;

namespace MoreLoopse
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            // kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            // siis konsoolis kuvatakse "Tere tulemast"
            // muu konsoolis kuvatakse "Vale kasutajatunnus vüi salasõna. Proovi uuesti."

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna");
            string userPassword = Console.ReadLine();

            //AND või OR

            //"admin" AND "admin1234"-->
            

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");


            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
        }
    }
}
