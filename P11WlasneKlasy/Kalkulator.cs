using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11WlasneKlasy
{
    // co to jest klasa? 
    // to jest definicja jakieś narzędzia
    class Kalkulator
    {
        //1) Pola <- to (prawie) samo co właściwość
        //2) Wlasciwosci <- właściwości , cechy danego obiektu
        //3) Konstruktory <- wymuszenie na prgoramiście sposobu tworzenia tego obiektu
        //4) Metody <- czynności jakie obiekt moze wykonać

        public string Kolor;

        public int Dodaj(int a, int b)
        {
            string s = "ala ma kota";
            int c = s.Length;

            int d = a + b;

            return d;
        }

        public int Odejmij(int a, int b)
        {
            return a - b;
        }


    }
}
