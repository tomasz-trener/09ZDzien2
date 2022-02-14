using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab1 = new string[3];

            //tab1[3] = "a"; wyjscie poza zakres tablicy

            List<string> lista1 = new List<string>(); // w tym monecie ma 0 elementow 

            lista1.Add("jan");
            lista1.Add("adam");
            lista1.Add("ola");

            int ileElementowMaLista = lista1.Count;

            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine(lista1[i]);
            }

            lista1.Insert(2, "ala");

            lista1.RemoveAt(0);

            Console.ReadKey();
            
        }
    }
}
