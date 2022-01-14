using System;


namespace ConsoleApp1
{
    class Liczba
    {
        private char[] cyfry;
        public void Wypisz()
        {
            Console.WriteLine(cyfry);
        }
        public Liczba(String liczba)
        {
            cyfry = liczba.ToCharArray();
        }
        public void Mnozenie(int n)
        {
            String sc = new String(cyfry);
            int ic = int.Parse(sc);
            ic *= n;
            cyfry = ic.ToString().ToCharArray();
        }
        public int Silnia(int n)
        {
            if (n < 2)
                return 1;
            else
                return n * Silnia(n-1);
        }
    }
}
