using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11WlasneKlasy
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime

            StringBuilder sb = new StringBuilder();
            Kalkulator k = new Kalkulator();
            k.Kolor = "Czerwony";

            int a= k.Dodaj(2, 4);


            Kalkulator k2 = new Kalkulator();
            k2.Kolor = "Niebieski";

            Console.WriteLine(a);


        }
    }
}
