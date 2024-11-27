using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOP
{
    public class HTipus
    {
        private int a, b, c;

        public HTipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool valosharomszoge()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public bool derekszogue()
        {
            return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
        }

        public bool egyenloszarue()
        {
            return (a == b) || (b == c) || (a == c);
        }

        public bool egyenlooldalue()
        {
            return (a == b) && (b == c);
        }

        public double terulet()
        {
            if (!valosharomszoge())
                throw new InvalidOperationException("Nem érvényes háromszög!");

            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.objektum
            HTipus haromszog1 = new HTipus(5, 12, 13);
            Console.WriteLine($"A háromszög érvényes: {haromszog1.valosharomszoge()}");
            Console.WriteLine($"Derékszögű háromszög: {haromszog1.derekszogue()}");
            Console.WriteLine($"Egyenlő szárú háromszög: {haromszog1.egyenloszarue()}");
            Console.WriteLine($"Egyenlő oldalú háromszög: {haromszog1.egyenlooldalue()}");
            Console.WriteLine($"Terület: {haromszog1.terulet()}");
            Console.WriteLine();
            #endregion Eof 1.objektum
            #region 2.objektum
            HTipus haromszog2 = new HTipus(5, 5, 5);
            Console.WriteLine($"A háromszög érvényes: {haromszog2.valosharomszoge()}");
            Console.WriteLine($"Derékszögű háromszög: {haromszog2.derekszogue()}");
            Console.WriteLine($"Egyenlő szárú háromszög: {haromszog2.egyenloszarue()}");
            Console.WriteLine($"Egyenlő oldalú háromszög: {haromszog2.egyenlooldalue()}");
            Console.WriteLine($"Terület: {haromszog2.terulet()}");
            Console.WriteLine();
            #endregion Eof 2.objektum
            #region 3.objektum
            HTipus haromszog3 = new HTipus(30, 30, 23);
            Console.WriteLine($"A háromszög érvényes: {haromszog3.valosharomszoge()}");
            Console.WriteLine($"Derékszögű háromszög: {haromszog3.derekszogue()}");
            Console.WriteLine($"Egyenlő szárú háromszög: {haromszog3.egyenloszarue()}");
            Console.WriteLine($"Egyenlő oldalú háromszög: {haromszog3.egyenlooldalue()}");
            Console.WriteLine($"Terület: {haromszog3.terulet()}");
            #endregion Eof 3.objektum
            Console.ReadKey();
        }
    }
}
