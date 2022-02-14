using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "jan";
            string s2 = "adam";
            string s3 = "ola";

            string[] tablica = new string[4];

            tablica[0] = "jan";
            tablica[1] = s2;
            tablica[2] = "ola";

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }

            int[] liczby = new int[3];

            // niektóre typy mają domyślną wartość = null,
            // a niektóre mają jakąś inną konkretną wartość domyślną np 0 w przypadku int 

            bool[] wartosciLogiczne = new bool[2];
 
            Console.ReadKey();
        }
    }
}
