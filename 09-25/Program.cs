using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Írjunk olyan programot, amely addig kér
be egész számokat a billentyűzetről, amíg azok összege meg nem haladja a 100-at. A
beolvasás végén írjuk ki azt, hogy a bekért számok közül hány volt páros, és hány volt
páratlan.*/

namespace test2
{
    class tobbElemOsztaly
    {
        //osztalyvaltozo
        private int szam;
        private bool isparos;
        //konstruktor
        public tobbElemOsztaly()
        {
            szam = 0;
            isparos = false;
        }

        public void Getszam(int p)
        {
            szam = p;
        }

        public void setszamtipus()
        {
            isparos = szam % 2 == 0;
        }
        public bool outszamtipus()
        {
            return this.isparos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //osztalyvaltozo
            string valasz = string.Empty;
            int paros = 0,
                szam = 0,
            paratlan = 0;

            //példányosítjuk az osztákyt
            //másnéven objektumokat hoztunk létre az osztálynak

            tobbElemOsztaly a = new tobbElemOsztaly();

            //szám megoldása
            while (paros + paratlan < 100)
            {
                Console.WriteLine("adj meg egy egész számot");
                szam = Convert.ToInt32(Console.ReadLine());

                a.Getszam(15);
                a.setszamtipus();
                if (a.outszamtipus())
                {
                    valasz = "paros";
                    paros++;
                }
                else
                {
                    valasz = "paratlan";
                    paratlan++;
                }
                Console.WriteLine($"A szám típusa: {valasz}, eddig {paros + paratlan} számot adott meg. ");
                Console.ReadKey();
            }
        }
    }
}