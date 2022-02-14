using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Konstruktory
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;

        public int Wzrost;
        public int Waga;

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public Osoba(string imie, string nazwisko, int waga) : this(imie, nazwisko)
        {
            //Imie = imie;
            //Nazwisko = nazwisko;
            Waga = waga;
        }
        // teraz mogę osobę utworzyć na 2 sposoby


        public string PrzedstawSie()
        {
            return "Nazyawm sie " + Imie + " " + Nazwisko;
            //Console.WriteLine(
            //    "Nazywam sie " +
            //    Imie + 
            //    " " + 
            //    Nazwisko
            //    );
        }

    }
}
