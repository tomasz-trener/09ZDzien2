using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P16BibliotekaManagerZawodnikow
{
   public class ManagerZawodnikow
    {
        public Zawodnik[] WczytajZawodnikow()
        {
            WebClient wc = new WebClient();
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = wc.DownloadString(url);

            string[] wiersze = dane.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length - 1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Zawodnik zi = new Zawodnik();
                zi.Id = Convert.ToInt32(komorki[0]);

                if (!string.IsNullOrEmpty(komorki[1]))

                    zi.IdTrenera = Convert.ToInt32(komorki[1]);
                zi.Imie = komorki[2];
                zi.Nazwisko = komorki[3];
                zi.Kraj = komorki[4];
                zi.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                zi.Waga = Convert.ToInt32(komorki[6]);
                zi.Wzrost = Convert.ToInt32(komorki[7]);
                zawodnicy[i - 1] = zi;
            }
            return zawodnicy;
        }
    }
}
