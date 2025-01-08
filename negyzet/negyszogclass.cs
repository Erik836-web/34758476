using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyzet
{
    class negyszogclass
    {
        //Osztályváltozók

        protected double a_old,
            b_old,
            kerulet,
            kerulet2,
            terulet,
            terulet2;

        //Konstruktorok
        public negyszogclass() { }

        public negyszogclass(double a)
        {
            this.a_old = a;
        }
        public negyszogclass(double a, double b)
        {
            this.a_old = a;
            this.b_old = b;
        }

        //metodusok

        public void ReadAoldal(double a)
        {
            this.a_old = a;
        }

        public void ReadBoldal(double b)
        {
            this.b_old = b;
        }

        public void SetKerulet()
        {
            this.kerulet = 4 * a_old;
        }

        public void SetKerulet2()
        {
            this.kerulet2 = 2 * (a_old + b_old);
        }

        public void SetTerulet()
        {
            this.terulet = a_old * a_old;
        }

        public void SetTerulet2()
        {
            this.terulet2 = a_old * b_old;
        }
        public double GetKerulet() { return this.kerulet; }
        public double GetKerulet2() { return this.kerulet2; }
        public double GetTerulet() { return this.terulet; }
        public double GetTerulet2() { return this.terulet2; }

        public double GetAoldal() { return this.a_old; }
        public double GetBoldal() { return this.b_old; }
    }
}

helyi menü tartozik hozzá