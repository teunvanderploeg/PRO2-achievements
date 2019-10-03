using System;

namespace QuestionsAndAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            String trots = "";
            string deZin = "";
            Console.Clear();
            Console.WriteLine("Hallo dit zijn wat vragen.");
            Console.WriteLine("andwoord met ja of nee");
            Console.WriteLine("");

            Console.WriteLine("Hou je van vis?");
            trots = Console.ReadLine();
            if (trots == "nee")
            {

                deZin = deZin + " Je vind vis niet lekker.";
            }
            else if (trots == "ja")
            {

                deZin = deZin + " Je vind vis lekker.";
            }
            else
            {
                Console.WriteLine("Je moet ja of nee in invullen");
            }

            Console.WriteLine("wil je kip?");
            trots = Console.ReadLine();
            if (trots == "nee")
            {
                deZin = deZin + " Je vind kip heel smerig.";
            }
            else if (trots == "ja")
            {
                deZin = deZin + " Je vind kip herlijk.";
            }

            else
            {
                Console.WriteLine("Je moet ja of nee in invullen");
            }

            Console.WriteLine("Vind je water lekker?");
            trots = Console.ReadLine();
            if (trots == "nee")
            {
                deZin = deZin + " Je vind water niet lekker.";
            }
            else if (trots == "ja")
            {
                deZin = deZin + " Je vind water lekker.";
            }
            else
            {
                Console.WriteLine("Je moet ja of nee in invullen");
            }

            Console.WriteLine("Eet je van een bord?");
            trots = Console.ReadLine();
            if (trots == "nee")
            {
                deZin = deZin + " En je eet niet van een bord.";
            }
            else if (trots == "ja")
            {
                deZin = deZin + " En je eet van een bord.";
            }
            else
            {
                Console.WriteLine("Je moet ja of nee in invullen");
            }
            Console.WriteLine("");
            Console.WriteLine(deZin);
            Console.Beep(100, 100);
        }
    }
}
