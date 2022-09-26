using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace basics_oefenen
{
    class Program
    {
        static void Main(string[] args) // https://www.w3schools.com/cs/cs_switch.asp (switch)
        {
            Console.WriteLine("Voer een getal in");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 10)
            {
                Console.WriteLine("Het getal is groter dan 10");
            }
            else if (getal == 10)
            {
                Console.WriteLine("Het getal is 10");
            }
            else
            {
                Console.WriteLine("Het getal is kleiner dan 10");
            }

            Double a = 3, b = 4, c = 5;

            Console.WriteLine("Wortel van 3 ~ "+ Math.Round(Math.Sqrt(a)));
            Console.WriteLine("Wortel van 4 ~ "+Math.Round(Math.Sqrt(b)));
            Console.WriteLine("Wortel van 5 ~ "+Math.Round(Math.Sqrt(c)));

            Console.WriteLine("Voer naam in");
            string name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            Console.WriteLine("Voer voornaam in");
            string firstName = Console.ReadLine();
            Console.WriteLine("Voer achternaam in");
            string lastName = Console.ReadLine();
            string fullName = $"{ firstName} { lastName}";
            Console.WriteLine(fullName);

            Console.WriteLine("Voorletters: " + firstName[0] + lastName[0]);
            Console.WriteLine(fullName.IndexOf("a"));

            Console.WriteLine("Auto\'s");



        }
    }
}
