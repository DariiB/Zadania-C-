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
// ---------------- ZADANIE 7 --------------------
static void Zadanie7()
{
    Console.WriteLine("ZADANIE 7");
    Console.WriteLine("Wpisz zdanie:");
    string tekst = Console.ReadLine().Trim();

    if (tekst == "")
    {
        Console.WriteLine("Ilość słów: 0");
        return;
    }

    string[] slowa = tekst.Split(' ');
    Console.WriteLine("Ilość słów: " + slowa.Length);
}

// ---------------- ZADANIE 8 --------------------
static void Zadanie8()
{
    Console.WriteLine("ZADANIE 8");
    Console.WriteLine("Wpisz zdanie:");
    string tekst = Console.ReadLine();

    string[] slowa = tekst.Split(' ');
    string akronim = "";

    foreach (string s in slowa)
    {
        if (s.ToLower() == "of") continue; // pomijamy "of"
        if (s.Length > 0)
            akronim += s[0];
    }

    Console.WriteLine("Akronim: " + akronim.ToUpper());
}

// ---------------- ZADANIE 9 --------------------
static void Zadanie9()
{
    Console.WriteLine("ZADANIE 9");
    Console.WriteLine("Podaj e-mail:");
    string email = Console.ReadLine();

    int index = email.IndexOf('@');
    if (index == -1)
    {
        Console.WriteLine("Niepoprawny e-mail.");
        return;
    }

    string domena = email.Substring(index + 1);
    Console.WriteLine("Domena: " + domena);
}

// ---------------- ZADANIE 10 --------------------
static void Zadanie10()
{
    Console.WriteLine("ZADANIE 10");
    Console.WriteLine("Wpisz zdanie:");
    string tekst = Console.ReadLine();

    string[] zakazane = { "kot", "pies" };

    foreach (string z in zakazane)
    {
        tekst = tekst.Replace(z, new string('*', z.Length));
    }

    Console.WriteLine("Po cenzurze: " + tekst);
}

// ---------------- ZADANIE 10.1 --------------------
static void Zadanie10_1()
{
    Console.WriteLine("ZADANIE 10.1");
    Console.WriteLine("Wpisz zdanie:");
    string tekst = Console.ReadLine();

    Console.WriteLine("Podaj słowa zakazane (oddzielone spacją):");
    string[] zakazane = Console.ReadLine().Split(' ');

    foreach (string z in zakazane)
    {
        tekst = tekst.Replace(z, new string('*', z.Length));
    }

    Console.WriteLine("Po cenzurze: " + tekst);
}

// ---------------- ZADANIE 10.2 --------------------
static void Zadanie10_2()
{
    Console.WriteLine("ZADANIE 10.2");
    Console.WriteLine("Wpisz zdanie:");
    string tekst = Console.ReadLine();

    Console.WriteLine("Podaj słowa zakazane:");
    string[] zakazane = Console.ReadLine().Split(' ');

    foreach (string z in zakazane)
    {
        tekst = System.Text.RegularExpressions.Regex.Replace(
            tekst,
            z,
            new string('*', z.Length),
            System.Text.RegularExpressions.RegexOptions.IgnoreCase
        );
    }

    Console.WriteLine("Po cenzurze: " + tekst);
}

// ---------------- ZADANIE 11 --------------------
static void Zadanie11()
{
    Console.WriteLine("ZADANIE 11");
    Console.WriteLine("Wpisz tekst:");
    string tekst = Console.ReadLine();

    string wynik = "";
    foreach (char c in tekst)
    {
        if (char.IsDigit(c))
            wynik += "LICZBA";
        else
            wynik += c;
    }

    Console.WriteLine(wynik);
}

// ---------------- ZADANIE 11.1 --------------------
static void Zadanie11_1()
{
    Console.WriteLine("ZADANIE 11.1");
    Console.WriteLine("Wpisz tekst:");
    string tekst = Console.ReadLine();

    string[] cyfry = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };

    string wynik = "";
    foreach (char c in tekst)
    {
        if (char.IsDigit(c))
            wynik += cyfry[c - '0'];
        else
            wynik += c;
    }

    Console.WriteLine(wynik);
}

// ---------------- ZADANIE 12 --------------------
static void Zadanie12()
{
    Console.WriteLine("ZADANIE 12");
    Console.WriteLine("Wpisz tekst:");
    string tekst = Console.ReadLine();

    Console.WriteLine("Wpisz słowo do wyszukania:");
    string slowo = Console.ReadLine();

    if (tekst.Contains(slowo))
        Console.WriteLine("Znaleziono na indeksie: " + tekst.IndexOf(slowo));
    else
        Console.WriteLine("Nie znaleziono.");
}

// ---------------- ZADANIE 13 --------------------
static void Zadanie13()
{
    Console.WriteLine("ZADANIE 13");
    Console.WriteLine("Wpisz imię i nazwisko:");
    string dane = Console.ReadLine();

    string[] tab = dane.Split(' ');
    if (tab.Length != 2)
    {
        Console.WriteLine("Podaj dokładnie imię i nazwisko.");
        return;
    }

    string imie = tab[0][0].ToString().ToUpper() + tab[0].Substring(1).ToLower();
    string nazwisko = tab[1][0].ToString().ToUpper() + tab[1].Substring(1).ToLower();

    Console.WriteLine(imie + " " + nazwisko);
}

// ---------------- ZADANIE 14 --------------------
static void Zadanie14()
{
    Console.WriteLine("ZADANIE 14");
    Console.WriteLine("Wpisz tekst:");
    string tekst = Console.ReadLine();

    string wynik = "";
    for (int i = 0; i < tekst.Length; i++)
    {
        if (i % 2 == 0)
            wynik += char.ToLower(tekst[i]);
        else
            wynik += char.ToUpper(tekst[i]);
    }

    Console.WriteLine(wynik);
}

// ---------------- ZADANIE 15 --------------------
static void Zadanie15()
{
    Console.WriteLine("ZADANIE 15");
    Console.WriteLine("Wpisz zdanie:");
    string tekst = Console.ReadLine();

    string[] slowa = tekst.Split(' ');
    string wynik = "";

    for (int i = slowa.Length - 1; i >= 0; i--)
        wynik += slowa[i] + " ";

    Console.WriteLine(wynik.Trim());
}

// ---------------- ZADANIE 16 --------------------
static void Zadanie16()
{
    Console.WriteLine("ZADANIE 16");
    Console.WriteLine("Podaj dane w formacie Imię,Nazwisko,Wiek:");
    string tekst = Console.ReadLine();

    string[] dane = tekst.Split(',');

    if (dane.Length != 3)
    {
        Console.WriteLine("Błędny format.");
        return;
    }

    Console.WriteLine("Imię: " + dane[0]);
    Console.WriteLine("Nazwisko: " + dane[1]);
    Console.WriteLine("Wiek: " + dane[2]);
}

// ---------------- ZADANIE 17 --------------------
static void Zadanie17()
{
    Console.WriteLine("ZADANIE 17");
    Console.WriteLine("Wpisz zdanie:");
    string tekst = Console.ReadLine().ToLower();

    string samogloski = "aeiouyąęó";
    int ileSam = 0, ileSpol = 0;

    foreach (char c in tekst)
    {
        if (char.IsLetter(c))
        {
            if (samogloski.Contains(c))
                ileSam++;
            else
                ileSpol++;
        }
    }

    Console.WriteLine("Liczba samogłosek: " + ileSam);
    Console.WriteLine("Liczba spółgłosek: " + ileSpol);
}

// ---------------- ZADANIE 18 --------------------
static void Zadanie18()
{
    Console.WriteLine("ZADANIE 18");
    Console.WriteLine("Wpisz tekst do zaszyfrowania:");
    string tekst = Console.ReadLine();

    Console.WriteLine("Podaj klucz (liczbę przesunięcia):");
    int klucz = int.Parse(Console.ReadLine());

    string wynik = "";

    foreach (char c in tekst)
    {
        if (char.IsLetter(c))
        {
            char baza = char.IsUpper(c) ? 'A' : 'a';
            char zaszyfrowany = (char)(baza + (c - baza + klucz) % 26);
            wynik += zaszyfrowany;
        }
        else
        {
            wynik += c; // spacje, cyfry, znaki specjalne bez zmian
        }
    }

    Console.WriteLine("Zaszyfrowany tekst: " + wynik);
}
