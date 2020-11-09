using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajlev_1109
{

    //érték típus
    struct EmberS
    {
        public string nev;
        public int eletkor;
    }

    //referencia típus
    class EmberC
    {
        public string nev;
        public int eletkor;
    }


    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new EmberS() {nev = "Zoli", eletkor = 30, };
            var c1 = new EmberC() {nev = "Zoli", eletkor = 30, };

            var s2 = s1;
            var c2 = c1;

            s2.nev = "Jolánka";
            c2.nev = "Jolánka";

            Console.WriteLine($"Nev: {s1.nev}\nKor: {s1.eletkor}");
            Console.WriteLine($"Nev: {c1.nev}\nKor: {c1.eletkor}");


            Console.ReadKey();
        }
    }
}
