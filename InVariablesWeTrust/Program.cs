using System;

namespace in_variables_we_trust
{
    class Program
    {
        static void Main(string[] args)
        {
            char eenA = 'A';
            float flieg = 10;
            bool ja = true;
            bool nee = false;
            int leven = 0;
            int dagen = 100;
            int jaar = 365;
            string beginer = "welkom beginer";
            string hetBegin = "welkom bij het begin";
            string naam = hetBegin + beginer;
            Console.WriteLine(eenA);

            Console.WriteLine(flieg);

            Console.WriteLine(ja);
            Console.WriteLine(nee);

            Console.WriteLine(leven);
            Console.WriteLine(dagen);
            Console.WriteLine(jaar);
            Console.WriteLine(dagen - jaar);

            Console.WriteLine(beginer);
            Console.WriteLine(hetBegin);
            Console.WriteLine(naam);
        }
    }
}
