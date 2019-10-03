using System;

namespace QuestionsAndAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            String trots = "";
            int punten = 0;
            Console.Clear();
            Console.WriteLine("Hallo dit zijn wat vragen.");
            Console.WriteLine("andwoord met ja of nee");
            Console.WriteLine("");
            Console.WriteLine("Is de wereld plat?");
            trots = Console.ReadLine();
            if (trots == "nee")
            {
                Console.WriteLine("Je hebt helemaal gelijk.");
                punten++;
            }
            else if (trots == "ja")
            {
                Console.WriteLine("Nee dat klopt niet.");
            }
            else
            {
                Console.WriteLine("Je moet ja of nee in invullen");
            }
            Console.WriteLine("ben je al dood?");
            trots = Console.ReadLine();
            if (trots == "nee")
            {
                Console.WriteLine("Je hebt helemaal gelijk.");
                punten++;
            }
            else if (trots == "ja")
            {
                Console.WriteLine("Nee dat klopt niet, dat zou best gek zijn.");
            }
            else
            {
                Console.WriteLine("Je moet ja of nee in invullen");
            }
            Console.WriteLine("Kan je op water staan?");
            trots = Console.ReadLine();
            if (trots == "nee")
            {
                Console.WriteLine("Je hebt helemaal gelijk.");
                punten++;
            }
            else if (trots == "ja")
            {
                Console.WriteLine("Nee dat klopt niet.");
            }
            else
            {
                Console.WriteLine("Je moet ja of nee in invullen");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Beep(100, 100);
            Console.WriteLine("Je punten zijn:" + punten);
        }
    }
}
