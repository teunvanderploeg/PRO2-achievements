using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            string woonplaats;
            string kleuroog;
            string postkcode;
            Console.Clear();
            Console.WriteLine("Hallo ik ben Teun.");
            Console.WriteLine("Wat is jou voor en achternaam?");
            naam = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(naam + " waar woon je?");
            woonplaats = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wat is je de kleur van je ogen " + naam + ".");
            kleuroog = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("En wat is je postcode?");
            postkcode = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("Dankje voor je meewerking.");
            Console.WriteLine("Dit is de info dat we over je hebben.");
            Console.WriteLine();
            Console.WriteLine("Je naam is " + naam + ". En je oog kleur is " + kleuroog + ".");
            Console.WriteLine("Je woont in " + woonplaats + ". En je postcode is " + postkcode + ".");
            Console.ReadLine();
        }
    }
}
