using System;

namespace OOP_LABB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometri:"); //skriver ut metoder och deras standardsatta värden 
            Geometri nyy = new Geometri();
            nyy.Area();

            Console.WriteLine("Rektangel:");
            Rektangel test = new Rektangel();
            test.Area();


            Console.WriteLine("Cirkel:");
            Cirkel testt = new Cirkel();
            testt.Area();

            Console.WriteLine("Trekant:");
            Trekant att = new Trekant();
            att.Area();



        }
    }
}
