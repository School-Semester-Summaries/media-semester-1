using System;

namespace Oppervlakte.Rechthoek.Berekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies waarvan je de oppervlakte wilt berekenen");
            Console.WriteLine("Rechthoek = 1");
            Console.WriteLine("Driehoek = 2");

            int Keuze = Convert.ToInt32(Console.ReadLine());

            if (Keuze > 0 & Keuze < 2) // 1
            {
                Console.WriteLine("Oppervlakte rechthoek uitrekenen");
                Console.WriteLine("Voer lengte in");
                int Lengte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Voer breedte in");
                int Breedte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Oppervlakte = " + (Lengte * Breedte));

                Console.WriteLine("Voer '0' in voor uitleg of voer '1' in om door te gaan");
                int X1 = Convert.ToInt32(Console.ReadLine());
                if (X1 < 1)
                {
                    Console.WriteLine("Oppervlakte rechthoek = Lengte * Breedte");
                    Console.WriteLine("Oppervlakte rechthoek = " + Lengte + " * " + Breedte);
                    Console.WriteLine("Oppervlakte rechthoek = " + Lengte * Breedte);
                }

                if (X1 > 1)
                {
                    Console.WriteLine("0 of 1 >:(");
                    // loop naar uitleg of niet
                }
            }

                if (Keuze > 1 & Keuze < 3) // 2
                {
                    Console.WriteLine("Oppervlakte driehoek uitrekenen");
                    Console.WriteLine("Voer basis in");
                    int Basis = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Voer hoogte in");
                    int Hoogte = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Oppervlakte = " + (Basis * Hoogte / 2));

                    Console.WriteLine("Voer '0' in voor uitleg of voer '1' in om door te gaan");
                    int X2 = Convert.ToInt32(Console.ReadLine());
                    if (X2 < 1)
                    {
                        Console.WriteLine("Oppervlakte driehoek = 0,5 * Basis * Hoogte");
                        Console.WriteLine("Oppervlakte driehoek = 0,5 * " + Basis + " * " + Hoogte);
                        Console.WriteLine("Oppervlakte driehoek = " + Basis * Hoogte / 2);
                    }

                    if (X2 > 1)
                    {
                        Console.WriteLine("0 of 1 >:(");
                        // loop naar uitleg of niet
                    }
                }
            
        }
    }
}
