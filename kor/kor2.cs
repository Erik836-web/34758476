using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class kor2
    {
        //osztályváltozók
        private double sugar,
                       kerulet,
                       terulet;
        
        //konstruktorok

            public kor2()
        {

        }

        public kor2(double r)

        {

            this.sugar = r;
            szamitasok();
            kalkkerulet();
            this.terulet = kalkterulet(this.sugar);
        }

        //metodusok

        public void Setsugar(double r)
        {
            this.sugar = r;
        }

        private void kalkkerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }

        private double kalkterulet(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        private void szamitasok()
        {
            kalkkerulet();
            this.terulet = kalkterulet(this.sugar);
        }

        public double getker()
        {
            return this.kerulet;
        }

        public double getter()
        {
            return this.terulet;
        }

        public double getsug()
        {
            return this.sugar;
        }
    }
}
