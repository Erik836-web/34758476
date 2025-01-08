using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varos
{
    class Program
    {
        static void Main(string[] args)
        {
            varosok varosok = new varosok();
            varosok.setDb();
            varosok.getNevek();
            varosok.getVan();
            varosok.delNev();
            varosok.delLast();

            Console.ReadLine();
        }
    }
}