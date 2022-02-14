using P16BibliotekaManagerZawodnikow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P15AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy= mz.WczytajZawodnikow();

            for (int i = 0; i < zawodnicy.Length; i++)
                lbDane.Items.Add(zawodnicy[i].ImieNazwisko);
           
        }
    }
}
