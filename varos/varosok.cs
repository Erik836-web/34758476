using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varos
{
    class varosok
    {
        private List<string> varosNevek = new List<string>();

        public void setDb()
        {
            Console.Write("Hány városnevet szeretne eltárolni? ");
            string input = Console.ReadLine();
            int db;

            while (!int.TryParse(input, out db) || db < 0)
            {
                Console.Write("Kérem, adjon meg egy érvényes számot: ");
                input = Console.ReadLine();
            }

            for (int i = 0; i < db; i++)
            {
                setNevek();
            }
        }

        public void setNevek()
        {
            Console.Write("Kérem, adja meg a város nevét (üres mező a befejezéshez): ");
            string nev = Console.ReadLine();

            while (!string.IsNullOrEmpty(nev))
            {
                varosNevek.Add(nev);
                nev = Console.ReadLine();
            }
        }

        public void getNevek()
        {
            Console.WriteLine("A tárolt városnevek: " + string.Join(", ", varosNevek));
        }

        public void getVan()
        {
            Console.Write("Kérem, adjon meg egy városnevet: ");
            string nev = Console.ReadLine();

            if (varosNevek.Contains(nev))
            {
                Console.WriteLine($"{nev} szerepel a listában.");
            }
            else
            {
                Console.WriteLine($"{nev} nem szerepel a listában.");
            }
        }

        public void delNev()
        {
            Console.Write("Kérem, adjon meg egy városnevet a törléshez vagy hozzáadáshoz: ");
            string nev = Console.ReadLine();

            if (varosNevek.Contains(nev))
            {
                varosNevek.Remove(nev);
                Console.WriteLine($"{nev} törölve lett a listából.");
            }
            else
            {
                varosNevek.Add(nev);
                Console.WriteLine($"{nev} hozzáadva a listához.");
            }
        }

        public void delLast()
        {
            if (varosNevek.Count > 0)
            {
                varosNevek.RemoveAt(varosNevek.Count - 1);
                Console.WriteLine("Az utolsó városnév törölve lett.");
            }
            else
            {
                Console.WriteLine("A lista üres, nincs mit törölni.");
            }
        }
    }
}