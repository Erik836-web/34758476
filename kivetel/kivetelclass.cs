using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetel
{
    class kivetelclass
    {
        public kivetelclass() { }
        //nincs kivétel kezelés
        public void kivKezOs()
        {
            Console.WriteLine("nincs kivételezés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("a beírt szám {0}", szam);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e . ToString());
            }
            Console.ReadKey();
        }
    }
}
