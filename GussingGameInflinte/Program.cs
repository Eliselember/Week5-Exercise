using System;

namespace GussingGameInflinte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti
            //"programm genereerib juhuslikku numbrit üks kord.
            //katsete arv on piiramatu
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Vali number 1-10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    //break
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti.");
                }
            }
        }
            
    }
}
