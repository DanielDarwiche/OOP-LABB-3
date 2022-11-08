using System;

namespace OOP_LABB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Följande är Geometri Area, som returnerar 0"); 
            Geometri Shape = new Geometri();//Skapar tom geometri sak som returnerar 0
            Shape.Area();//blir 0
            Console.WriteLine("\nFöljande är area med standardvärden och följande manuellt insatta värden"); 
            Shape = new Cirkel();//omvandlar Shape till tom cirkel med standardvärden
            Shape.Area();
            Shape = new Cirkel(9);//sätter in värde i cirkeln 
            Shape.Area();
            Console.WriteLine("\nFöljande är area med standardvärden och följande manuellt insatta värden");  
            Shape = new Rektangel();//omvandlar Shape till rektangel med standardvärde
            Shape.Area();
            Shape = new Rektangel(2, 9);//sätter in värden i rektangeln
            Shape.Area();
            Console.WriteLine("\nFöljande är area med standardvärden och följande manuellt insatta värden");  
            Shape = new Trekant();//omvandlar Shape till Trekant med standardvärden
            Shape.Area();
            Shape = new Trekant(3, 9);//sätter in värden i trekant
            Shape.Area();
        }
    }
}
