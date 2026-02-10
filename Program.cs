using System;

namespace Projekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1_2();

        }

        // ---------------- ZADANIE 1 ----------------
        static void Zadanie1()
        {
            Console.WriteLine("ZADANIE 1");
            Console.WriteLine("Wpisz zdanie:");
            string tekst = Console.ReadLine();

            Console.WriteLine("Długość tekstu: " + tekst.Length);
            Console.WriteLine("Wielkie litery: " + tekst.ToUpper());
            Console.WriteLine("Małe litery: " + tekst.ToLower());
        }

        // ---------------- ZADANIE 1.1 ----------------
        static void Zadanie1_1()
        {
            Console.WriteLine("ZADANIE 1.1");
            Console.WriteLine("Wpisz zdanie:");
            string tekst = Console.ReadLine();

            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("W - wielkie litery");
            Console.WriteLine("M - małe litery");

            string wybor = Console.ReadLine();

            if (wybor == "W")
                Console.WriteLine(tekst.ToUpper());
            else if (wybor == "M")
                Console.WriteLine(tekst.ToLower());
            else
                Console.WriteLine("Nie ma takiej opcji.");
        }

        // ---------------- ZADANIE 1.2 ----------------
        static void Zadanie1_2()
        {
            Console.WriteLine("ZADANIE 1.2");
            Console.WriteLine("Wpisz zdanie:");
            string tekst = Console.ReadLine();

            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("W - wielkie litery");
            Console.WriteLine("M - małe litery");
            Console.WriteLine("P - pierwsza litera duża");

            string wybor = Console.ReadLine();

            if (wybor == "W")
                Console.WriteLine(tekst.ToUpper());
            else if (wybor == "M")
                Console.WriteLine(tekst.ToLower());
            else if (wybor == "P")
            {
                string wynik = tekst[0].ToString().ToUpper() + tekst.Substring(1).ToLower();
                Console.WriteLine(wynik);
            }
            else
                Console.WriteLine("Nie ma takiej opcji.");
        }

        // ---------------- ZADANIE 2 --------------------
        static void Zadanie2()
        {
            Console.WriteLine("ZADANIE 2");
            Console.WriteLine("Wpisz tekst:");
            string tekst = Console.ReadLine();

            string bezSpacji = tekst.Trim();

            Console.WriteLine("Tekst bez spacji: " + bezSpacji);
            Console.WriteLine("Długość: " + bezSpacji.Length);

            if (bezSpacji.Length > 0)
            {
                Console.WriteLine("Pierwsza litera: " + bezSpacji[0]);
                Console.WriteLine("Ostatnia litera: " + bezSpacji[bezSpacji.Length - 1]);
            }
        }
        static void Zadanie3()
        {
            Console.WriteLine("Wpisz tekst:");
            string tekst = Console.ReadLine();

            Console.WriteLine("Wpisz znak do wyszukania:");
            char znak = Console.ReadLine()[0]; // znak pierwszy

            int licznik = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == znak)
                {
                    licznik++;
                }
            }

            Console.WriteLine($"Litera '{znak}' występuje {licznik} razy.");
        }
        static void Zadanie4()
        {
            Console.WriteLine("Wpisz zdanie:");
            string tekst = Console.ReadLine();

            string wynik = tekst.Replace(" ", "_");

            Console.WriteLine("Po zamianie: " + wynik);
        }

        static void Zadanie4_1()
        {
            Console.WriteLine("Wpisz zdanie:");
            string tekst = Console.ReadLine();

            Console.WriteLine("Na jaki znak zamienić spacje?");
            char znak = Console.ReadLine()[0]; // pierwszy znak wpisany przez użytkownika

            string wynik = tekst.Replace(" ", znak.ToString());

            Console.WriteLine("Po zamianie: " + wynik);
        }
        static void Zadanie5()
        {
            Console.WriteLine("Wpisz tekst:");
            string tekst = Console.ReadLine();

            string odwrocony = "";

            for (int i = tekst.Length - 1; i >= 0; i--)
            {
                odwrocony += tekst[i];
            }

            Console.WriteLine("Od tyłu: " + odwrocony);
        }
        static void Zadanie6()
        {
            Console.WriteLine("Wpisz tekst:");
            string tekst = Console.ReadLine();

            // Odwracanie tekstu
            string odwrocony = "";
            for (int i = tekst.Length - 1; i >= 0; i--)
            {
                odwrocony += tekst[i];
            }

            // Porównanie
            if (tekst == odwrocony)
            {
                Console.WriteLine("TAK – to jest palindrom.");
            }
            else
            {
                Console.WriteLine("NIE – to nie jest palindrom.");
            }
        }

    }
}
