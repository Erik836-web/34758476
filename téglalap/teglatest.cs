using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace téglalap
{
    class teglatest : tegla
    {
        

        private double c_old,
            terfogat,
            felszin;

        
        public teglatest(double a, double b, double c)
        {
            this.a_old = a;
            this.b_old = b;
            this.c_old = c;
            SetTerulet();
            this.terfogat = this.terulet * this.c_old;
        }

        public void ReadColdal(double c)
        {
            this.c_old = c;
        }

        public void Setfelszin()
        {
            this.felszin = 2 * (this.a_old * this.b_old + this.a_old * this.c_old + this.c_old * this.b_old);
        }

        public double getTerfogat()

        {

            return this.terfogat;

        }

        public double getFelszin()

        {

            return this.felszin;

        }

        public double GetColdal() { return this.c_old; }
    }
}
