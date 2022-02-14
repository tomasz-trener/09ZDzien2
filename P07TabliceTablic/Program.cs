using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07TabliceTablic
{
    class Program
    {
        static void Main(string[] args)
        {
            //mam 2 pojecia:
            //1) tablica 2- wymiarowa
            //2) tablica tablic (tablica postrzępiona) ang. jagged array

            // generalnie wygniejsza jest praca z tablicami tablic 

            string[][] tablicaTablic = new string[3][];

            tablicaTablic[0] = new string[2];
            tablicaTablic[1] = new string[3];
            tablicaTablic[2] = new string[1];

            tablicaTablic[0][0] = "1";
            tablicaTablic[0][1] = "2";
            
            tablicaTablic[1][0] = "3";
            tablicaTablic[1][1] = "4"; 
            tablicaTablic[1][2] = "5";

            tablicaTablic[2][0] = "6";


        }
    }
}
