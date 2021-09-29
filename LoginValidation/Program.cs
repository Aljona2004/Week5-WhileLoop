using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestada kasutajatunnus;
            //programm küsib kasutaja sisestada parool;
            //programm kontrollib, kas mõlemad, nii kasutajatunnus;
            //kui ka parool on õiged;
            //kui mõlemad, kasutajatunnus ja parool on õiged;
            //programm kuvab konsoolis "tere tulemast!";
            //kui kasutajatunnus või parool on vale, siis
            //programm kuvab "sisselogimine ebaõnnestus, proovi uuesti"
            //kt: admin, pr:admin1234
            //kasutajal on 3 katset

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
            }
            

            

        }
    }
}
