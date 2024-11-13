using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class henger : kor
    {
        //osztályváltozók

        private double magasság,
        terfogat;
        public henger(double r, double m)
        {
            this.sugar = r;
            this.magasság = m;
            SetKerulet();
            SetTerulet();
            this.terfogat = this.terulet * this.magasság;
        }
        public double getTerfogat()
        {
            return this.terfogat;
        }

        public double getmagassag()
        {
            return this.magasság;
        }
    }
}
