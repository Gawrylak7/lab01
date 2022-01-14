using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sumator
    {
        private int[] liczby = new int[] {};
        public int wynik;

        public Sumator(int[] liczby)
        {
            this.liczby = liczby;
        }

        public int Suma()
        {
            wynik = 0;
            for(int i=0;i<liczby.Length;i++)
            {
                wynik += liczby[i];
            }
            return wynik;
        }
        public int SumaPodziel2()
        {
            return Suma() / 2;
        }

        public int IleElementow()
        {
            return liczby.Length;
        }

        public void Wypisz()
        {
            int i = 0;
            Console.WriteLine("\nElementy tablicy:");
            foreach (int item in liczby)
            {
                 Console.WriteLine("tab["+i+"] = " +  liczby[i]);
                 i++;
            }
        }

        public void Wypisz2(int lowIndex, int highIndex)
        {
            for (int i = 0; i < liczby.Length; i++) 
            {
                if (i >= lowIndex && i <= highIndex)
                    Console.WriteLine("tab[" + i + "] = " + liczby[i]);
            }
        }
    }
}
