using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10TypyZmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a    = 6;
            string b = "ala ma kota";
            double c = 5.64;
            bool d   = false;
            char e   = 'k';

            //np data - coś bardziej złożonego 

            DateTime dt = new DateTime(2022, 01, 14);
            DateTime dt2= dt.AddDays(2);

            WebClient wc = new WebClient();
            string s= wc.DownloadString("http://tomaszles.pl");

            // w .NET mamy bardzo dużo różnych rodzajów obiektów, które mogą się nam przydać

            //np gdy mamy problem przechowywaia dużych tekstowych
            // i złącznaia tych ciągów ze sobą.

            StringBuilder sb = new StringBuilder();
            sb.Append("ala");
            sb.Append("ma");
            sb.Append("kota");

            string wynik = sb.ToString(); //alamakota
        }
    }
}
