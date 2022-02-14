using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04TabliceWielowyiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab1 = new string[3];

            string[,] tab2 = new string[3, 2];

            tab2[0, 0] = "1";
            tab2[1, 0] = "2";
            tab2[2, 0] = "3";

            tab2[0, 1] = "4";
            tab2[1, 1] = "5";
            tab2[2, 1] = "6";

            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    Console.Write(tab2[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
