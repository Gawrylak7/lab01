using System;

namespace ConsoleApp1
{
    class Data
    {
        private int dzien, miesiac, rok;

        public Data(int dzien, int miesiac, int rok)
        {
            this.dzien = dzien;
            this.miesiac = miesiac;
            this.rok = rok;
        }
        
        public void Wypisz()
        {
            Console.WriteLine("Podana data: "+dzien+"."+miesiac+"."+rok);
        }
       
        public void TydzDoPrzodu(DateTime d)
        {
            Console.WriteLine("Bieżąca data przestawiona o tydzień do przodu: "+ d.AddDays(7).ToString("d"));
        }
        public void TydzDoTylu(DateTime d)
        {
            Console.WriteLine("Bieżąca data przestawiona o tydzień do tyłu: " + d.AddDays(-7).ToString("d"));
        }
    }
}
