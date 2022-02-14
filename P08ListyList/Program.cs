using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ListyList
{
    class Program
    {
        static void Main(string[] args)
        {
            // nie ma czegoś takiego jak lista wielowymiarowa 
            // czyli odpowiednik tablicy wielowymiarowej 

            //ale za to mozemy stworzyc listę list 
            
            //to zwykła lista
            List<string> lista1 = new List<string>();

            //lista list
            List<List<string>> lista2 = new List<List<string>>();

            lista2.Add(new List<string>());
            lista2[0].Add("jan");
            lista2[0].Add("ola");

            lista2.Add(new List<string>());
            lista2[1].Add("adam");
            lista2[1].Add("ala");

            //http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt





        }
    }
}
