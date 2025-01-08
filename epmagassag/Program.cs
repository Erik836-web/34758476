using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace epmagassag

{

    class Program

    {

        static void Main(string[] args)

        {

            MagasOOP magasOOP = new MagasOOP();

            double aljMagassag = 10.0; // Példa alj magasság

            double teteMagassag = 25.0; // Példa tete magasság

            double magassag = magasOOP.MagassagSzamitas(aljMagassag, teteMagassag);

            Console.WriteLine($"A tereptárgy magassága: {magassag} méter");

            Console.ReadLine();

        }

    }

}

