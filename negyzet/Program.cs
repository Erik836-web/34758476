using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace negyzet

{

    class Program

    {

        static void Main(string[] args)

        {

            #region 1.objektum (negyzet)

            negyszogclass k1 = new negyszogclass();

            k1.ReadAoldal(10.0);

            k1.SetKerulet();

            k1.SetTerulet();

            Console.WriteLine($"A {k1.GetAoldal()} oldalú negyzet, kerülete: {k1.GetKerulet()}, területe: {k1.GetTerulet()} ");

            #endregion Eof 1.objektum

            #region 2. objektum (teglalap)

            negyszogclass k2 = new negyszogclass(21, 10);

            k2.SetKerulet2();

            k2.SetTerulet2();

            Console.WriteLine($"A {k2.GetAoldal()}, {k2.GetBoldal()} oldalú teglalap, kerülete: {k2.GetKerulet2()}, területe: {k2.GetTerulet2()} ");

            #endregion Eof 2. objektum

            Console.ReadLine();

        }

    }

}

