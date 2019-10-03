using System;

namespace Can_you_drive
{
    class Program
    {
        static void Main(string[] args)
        {
            string info;
            info = "";
            Console.Clear();
            Console.WriteLine("Hoe oud ben jij?");
            string input = Console.ReadLine();
            int age = Int32.Parse(input);
            if (age < 16)
            {
                Console.WriteLine("Je mag niet rijden!");
                info = "Je mag niet rijden!";
            }
            else if (age == 16)
            {
                info = "Je mag niet rijden.";
                Console.WriteLine("Heb jij al je scooter Rijbewijs?");
                input = Console.ReadLine();
                if (input == "ja" || input == "j")
                {

                    Console.WriteLine("Lekker dan!");
                    Console.WriteLine("Je mag wel scooter rijden.");
                    info = "JE mag scooter rijden";
                }
            }
            else if (age == 17)
            {
                info = "Je mag niet rijden.";
                Console.WriteLine("Heb jij al een Rijbewijs?");
                input = Console.ReadLine();
                if (input == "ja" || input == "j")
                {
                    Console.WriteLine("Lekker dan!");
                    Console.WriteLine("Aleen mag je niet alleen rijden.");
                    Console.WriteLine("Maar je mag wel alleen scooter rijden");
                    info = "Aleen mag je niet alleen rijden. Maar je mag wel alleen scooter rijden.";
                }
            }
            else if (age > 18)
            {
                info = "Je mag niet rijden.";
                Console.WriteLine("Heb jij al een Rijbewijs?");
                input = Console.ReadLine();
                if (input == "ja" || input == "j")
                {
                    Console.WriteLine("Lekker dan!");
                    Console.WriteLine("Dan mag je lekker rijden.");
                    info = "Je mag lekker rijden.";
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}
