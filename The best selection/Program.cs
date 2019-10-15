using System;

namespace The_best_selection
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string naam = "";
            string hoeveel = "";
            string[] names = { "Henk", "Jan", "Romer", "Martijn", "Teun", "Bob", "Theo", "Wout", "Bram", "Klaas" };
            Console.Clear();
            Console.WriteLine("[0]");
            Console.WriteLine(names[0]);
            Console.WriteLine();
            Console.WriteLine("[1]");
            Console.WriteLine(names[1]);
            Console.WriteLine();
            Console.WriteLine("[2]");
            Console.WriteLine(names[2]);
            Console.WriteLine();
            Console.WriteLine("[3]");
            Console.WriteLine(names[3]);
            Console.WriteLine();
            Console.WriteLine("[4]");
            Console.WriteLine(names[4]);
            Console.WriteLine();
            Console.WriteLine("[5]");
            Console.WriteLine(names[5]);
            Console.WriteLine();
            Console.WriteLine("[6]");
            Console.WriteLine(names[6]);
            Console.WriteLine();
            Console.WriteLine("[7]");
            Console.WriteLine(names[7]);
            Console.WriteLine();
            Console.WriteLine("[8]");
            Console.WriteLine(names[8]);
            Console.WriteLine();
            Console.WriteLine("[9]");
            Console.WriteLine(names[9]);

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("wil je een naam veranderen");
            input = Console.ReadLine();

            if (input == "ja" || input == "j")
            {
                Console.WriteLine();
                Console.WriteLine("Welke naam wil je veranderen? Een nummer.");
                hoeveel = Console.ReadLine();
                try
                {
                    int resultaat = Int32.Parse(hoeveel);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Waar in wil de naam in veranderen?");
                    naam = Console.ReadLine();
                    names[resultaat] = naam;
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Dit is geen nummer:", hoeveel);
                    Console.ReadLine();
                }


                Console.Clear();

                Console.WriteLine("[0]");
                Console.WriteLine(names[0]);
                Console.WriteLine();
                Console.WriteLine("[1]");
                Console.WriteLine(names[1]);
                Console.WriteLine();
                Console.WriteLine("[2]");
                Console.WriteLine(names[2]);
                Console.WriteLine();
                Console.WriteLine("[3]");
                Console.WriteLine(names[3]);
                Console.WriteLine();
                Console.WriteLine("[4]");
                Console.WriteLine(names[4]);
                Console.WriteLine();
                Console.WriteLine("[5]");
                Console.WriteLine(names[5]);
                Console.WriteLine();
                Console.WriteLine("[6]");
                Console.WriteLine(names[6]);
                Console.WriteLine();
                Console.WriteLine("[7]");
                Console.WriteLine(names[7]);
                Console.WriteLine();
                Console.WriteLine("[8]");
                Console.WriteLine(names[8]);
                Console.WriteLine();
                Console.WriteLine("[9]");
                Console.WriteLine(names[9]);
                Console.WriteLine("---------------------");
                Console.WriteLine("Dit is het lijstje");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("[0]");
                Console.WriteLine(names[0]);
                Console.WriteLine();
                Console.WriteLine("[1]");
                Console.WriteLine(names[1]);
                Console.WriteLine();
                Console.WriteLine("[2]");
                Console.WriteLine(names[2]);
                Console.WriteLine();
                Console.WriteLine("[3]");
                Console.WriteLine(names[3]);
                Console.WriteLine();
                Console.WriteLine("[4]");
                Console.WriteLine(names[4]);
                Console.WriteLine();
                Console.WriteLine("[5]");
                Console.WriteLine(names[5]);
                Console.WriteLine();
                Console.WriteLine("[6]");
                Console.WriteLine(names[6]);
                Console.WriteLine();
                Console.WriteLine("[7]");
                Console.WriteLine(names[7]);
                Console.WriteLine();
                Console.WriteLine("[8]");
                Console.WriteLine(names[8]);
                Console.WriteLine();
                Console.WriteLine("[9]");
                Console.WriteLine(names[9]);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine("Dit is het lijstje");
            }
        }
    }
}
