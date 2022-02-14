using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane= new WebClient().DownloadString(url);

            string[] wiersze =
                dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            string[][] wynik = new string[wiersze.Length-1][];

            for (int i = 1; i < wiersze.Length; i++)
            {
                // string[] komorki= wiersze[i].Split(';');
                string[] komorki = wiersze[i].Split(new string[1] { ";" },StringSplitOptions.RemoveEmptyEntries);
                wynik[i - 1] = komorki;
            }
        
        }
    }
}
