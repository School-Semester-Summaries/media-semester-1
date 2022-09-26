using System;

namespace Hoger_of_Lager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);

            Console.WriteLine("Raad het getal, het getal zit tussen 0 en 100.");

            int gok = Convert.ToInt32(Console.ReadLine());

            while (gok != number)
            {
                if (gok > number)
                {
                    Console.WriteLine("Lager");
                }

                if (gok < number)
                {
                    Console.WriteLine("Hoger");
                }
                gok = Convert.ToInt32(Console.ReadLine());
            }

            if (gok == number)
            {
                Console.WriteLine("Je hebt het getal geraden!");
            }

        }
    }
}
