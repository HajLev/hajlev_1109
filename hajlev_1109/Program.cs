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
        public string Nev;
        

        public int Eletkor;
    }

    //referencia típus
    class EmberC
    {
        private string _nev;
        public string Nev {
            set {
                if (value == "Lóci") throw new Exception("Nem lehet Lóci");
                _nev = value;
            }
            get {
                return _nev;
            }
        }

        private int _eletkor;
        public int Eletkor {
            set {
                if (value )
            }
            get {

            }
        }


        private int x = 0;
        private int y = 0;

        public void Mozog(int ujx, int ujy) {
            x = ujx;
            y = ujy;
        }

        public string HolVan() {
            return $"x: {x}, y: {y}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new EmberS() {nev = "Zoli", eletkor = 30, };
            var c1 = new EmberC() {nev = "Zoli", eletkor = 30, };

            //Deklarál egy új változót és átmásol minden értéket az eredeti memóriaterületről.
            var s2 = s1;

            //Létrehoz egy alias-t, ami ugyar arra a memóriaterületre mutet 
            var c2 = c1;

            //Az új megváltozik, az eredeti marad
            s2.nev = "Jolánka";
            //Mivel ez csak egy referencia, ezért akár c1-et vagy c2-t kérdezem le, a végeredmény nem változik
            c2.nev = "Jolánka";

            Console.WriteLine($"Nev: {s1.nev}\nKor: {s1.eletkor}");
            Console.WriteLine($"Nev: {c1.nev}\nKor: {c1.eletkor}");


            Console.ReadKey();
        }
    }
}
