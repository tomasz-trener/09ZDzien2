using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba c = new Osoba("Jan","Kowalski");

            Osoba c2 = new Osoba("Jan", "Kowalski", 80);

            //c.Imie = "Jan";
            //c.Nazwisko = "Kowalski";

            string s= c.PrzedstawSie();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
