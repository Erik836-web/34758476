using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class Program
    {
        static void Main(string[] args)
        {
            //A kor osztály felhsználása
            //1. objektum
            #region 1.objektum
            kor k1 = new kor(); // Sugár példány létrehozása üresen
            k1.ReadSugar(15.0); //sugár megadása
            k1.SetKerulet(); //Kiszámoltatjuk a kerületet
            k1.SetTerulet(); //Kiszámoltatjuk a területet

            Console.WriteLine($"A {k1.GetSugar()} sugarú kör, kerülete: {k1.GetKerulet()}, területe: {k1.GetTerulet()} ");
            #endregion Eof 1.objektum
            #region 2. objektum
            kor k2 = new kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();

            Console.WriteLine($"A {k2.GetSugar()} sugarú kör, kerülete: {k2.GetKerulet()}, területe: {k2.GetTerulet()} ");

            #endregion Eof 2. objektum

            kor2 k21 = new kor2(24.5);
            Console.WriteLine($"a kör adatai: \nsugár={k21.getsug()}, kerület = {k21.getker()}, terület = {k21.getter()}");

            henger h1 = new henger(15, 30);
            Console.WriteLine($"\n\nA henger adatai: \n sugara = {h1.GetSugar()}, magassága = {h1.getmagassag()}, \n alapterülete = {h1.GetTerulet()} = \n térfogata = {h1.getTerfogat()}");
                Console.ReadKey();
        }
    }
}
