using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P14AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string s = "ala ma kota";

            MessageBox.Show(s);

            txtNapis.Text = s;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntOdczytaj_Click(object sender, EventArgs e)
        {
            string s= txtNapis.Text;
            lblNapis.Text = s;
        }
    }
}
