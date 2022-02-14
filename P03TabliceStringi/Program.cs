using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03TabliceStringi
{
    class Program
    {
        static void Main(string[] args)
        {

            // z napisu do tablicy  
            string napis = "ala ma kota";

            string[] separatory = { " " };

            string[] tab= napis.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            // z tablicy na napis

            string wynik= string.Join("*^", tab);
            //ala*^ma*^kota


        }
    }
}
