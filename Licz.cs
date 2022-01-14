using System;

namespace classes
{
    class Licz
    {
        public float wartosc;
        //float wartosc;

        public float Dodaj(float a) {
            return wartosc += a;
        }

        public float Odejmij(float a)
        {
            return wartosc -= a;
        }

        public Licz(float wartosc)
        {
            this.wartosc = wartosc;
        }

        public void Wypisz() {
            Console.WriteLine("Wartosc: "+wartosc);
        }
    }
}