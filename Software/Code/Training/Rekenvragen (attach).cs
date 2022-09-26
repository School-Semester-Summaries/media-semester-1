using Microsoft.VisualBasic;
using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Je gaat nu een paar rekenvragen beantwoorden.");
            Console.WriteLine("We beginnen met 3 oefenopgaven, deze opgaven hebben geen invloed op je cijfer");
            Console.WriteLine("ROND KOMMA GETALLEN ALTIJD NAAR BENEDEN AF!");
            Console.WriteLine("Klik op een toets om door te gaan.");
            Console.ReadKey();

            int ans = 82; // ans is geen 0 omdat het antwoord op de volgende vraag vaak 0 kan zijn, zo heb je minder oefenopgaven
             
            int fouten = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();

                Random rnd = new Random();
                int getal1 = rnd.Next(1, 10);
                int getal2 = rnd.Next(1, 10);
                int plusMinKeerDelen = rnd.Next(1, 5);

                if (plusMinKeerDelen == 1) // +
                {
                    while (ans != getal1 + getal2)
                    {
                        Console.WriteLine("Wat is " + getal1 + " + " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 + getal2)
                        {
                            Console.WriteLine("Fout! Probeer het nog eens.");
                            fouten++;
                        }

                        if (ans == getal1 + getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    }

                    ans = 82; // Einde Som
                }

                if (plusMinKeerDelen == 2) // -
                {
                    while (ans != getal1 - getal2)
                    {
                        Console.WriteLine("Wat is " + getal1 + " - " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 - getal2)
                        {
                            Console.WriteLine("Fout! Probeer het nog eens.");
                            fouten++;
                        }

                        if (ans == getal1 - getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    }

                    ans = 82; // Einde som
                }

                if (plusMinKeerDelen == 3) // *
                {
                    while (ans != getal1 * getal2)
                    {
                        Console.WriteLine("Wat is " + getal1 + " x " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 * getal2)
                        {
                            Console.WriteLine("Fout! Probeer het nog eens.");
                            fouten++;
                        }

                        if (ans == getal1 * getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    }

                    ans = 82; // Einde som
                }

                if (plusMinKeerDelen == 4) // ÷ 
                {
                    while (ans != getal1 / getal2)
                    {
                        Console.WriteLine("Wat is " + getal1 + " ÷ " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 / getal2)
                        {
                            Console.WriteLine("Fout! Probeer het nog eens.");
                            fouten++;
                        }

                        if (ans == getal1 / getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    }

                    ans = 82; // Einde som
                }
            }
            if (fouten == 1)
            {
                Console.WriteLine("Je hebt bij de oefenopgaven 1 fout gemaakt.");
            }
            if (fouten == 0 || fouten > 1)
            {
                Console.WriteLine("Je hebt bij de oefenopgaven " + fouten + " fouten gemaakt.");
            }
            Console.WriteLine();
            Console.WriteLine("Nu ga je een toets maken met 20 rekenvragen. Je moet minstens 80% goed hebben, veel succes!");
            fouten = 0;

            for (int i = 0; i < 20; i++) // Begin toets 
            {

                Random rnd = new Random();
                int getal1 = rnd.Next(1, 10);
                int getal2 = rnd.Next(1, 10);
                int plusMinKeerDelen = rnd.Next(1, 5);

                Console.WriteLine();

                if (plusMinKeerDelen == 1) // +
                {
                    
                        Console.WriteLine("Wat is " + getal1 + " + " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 + getal2)
                        {
                            Console.WriteLine("Fout!");
                            fouten++;
                        }

                        if (ans == getal1 + getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    

                    ans = 0; // Einde Som
                }

                if (plusMinKeerDelen == 2) // -
                {
                    
                        Console.WriteLine("Wat is " + getal1 + " - " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 - getal2)
                        {
                            Console.WriteLine("Fout!");
                            fouten++;
                        }

                        if (ans == getal1 - getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    

                    ans = 0; // Einde som
                }

                if (plusMinKeerDelen == 3) // *
                {
                    
                        Console.WriteLine("Wat is " + getal1 + " x " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 * getal2)
                        {
                            Console.WriteLine("Fout!");
                            fouten++;
                        }

                        if (ans == getal1 * getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    

                    ans = 0; // Einde som
                }

                if (plusMinKeerDelen == 4) // ÷ 
                {
                    
                        Console.WriteLine("Wat is " + getal1 + " ÷ " + getal2);
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans != getal1 / getal2)
                        {
                            Console.WriteLine("Fout!");
                            fouten++;
                        }

                        if (ans == getal1 / getal2)
                        {
                            Console.WriteLine("Correct!");
                        }
                    
                    ans = 0; // Einde som
                }

            } // Einde Toets
            Console.WriteLine();
            Console.WriteLine("Fouten: " + fouten);
            if (fouten > 4) 
            {
                Console.WriteLine("Jammer, je bent gezakt. Je had " + (fouten - 4) + " fouten teveel");
            }
            if (fouten < 5 & fouten > 1) 
            {
                Console.WriteLine("Goed gedaan! je hebt de toets gehaald met " + fouten + " fouten");
            }
            if (fouten == 1)
            {
                Console.WriteLine("Goed gedaan! je hebt de toets gehaald met maar 1 fout!");
            }
            if (fouten == 0)
            {
                Console.WriteLine("Goed gedaan! je hebt de toets perfect gemaakt. Je bent een kanjer!");
            }
        }
    }
}
