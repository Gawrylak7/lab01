using classes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1.");
            Licz ob1 = new Licz(5);
            Console.WriteLine("Wartosc: "+ ob1.wartosc);
            ob1.Wypisz();
            Console.WriteLine("Dodaj: " + ob1.Dodaj(12));
            Console.WriteLine("Odejmij: " + ob1.Odejmij(2));
            
            Console.WriteLine("\nZadanie 2.");
            int[] tab = new int[4] { 2, 6, 1, 9 };
            Sumator s1 = new Sumator(tab);
            Console.WriteLine(s1.Suma());
            Console.WriteLine(s1.SumaPodziel2());
            Console.WriteLine(s1.IleElementow());
            s1.Wypisz();
            Console.WriteLine("\n");
            s1.Wypisz2(1, 3);
            
            Console.WriteLine("\nZadanie 3.\nPodaj date:\nDzień: ");
            int dzien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Miesiąc: ");
            int miesiac = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Rok: ");
            int rok = Convert.ToInt32(Console.ReadLine().Trim());
            Data d1 = new Data(dzien, miesiac, rok);
            d1.Wypisz();
            DateTime d2 = DateTime.Now;
            Console.WriteLine("Bieżąca data: " + d2.ToString("d"));
            d1.TydzDoPrzodu(d2);
            d1.TydzDoTylu(d2);

            Console.WriteLine("\nZadanie 4.");
            Liczba l1 = new Liczba("1957");
            l1.Wypisz();
            l1.Mnozenie(8);
            l1.Wypisz();
            Console.WriteLine("Silnia z 5 wynosi: " + l1.Silnia(5));
        }
    }
}
