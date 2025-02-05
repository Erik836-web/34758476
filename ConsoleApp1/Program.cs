using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstarct
{
    /*ez a példa az abstract kulcsszó használatát mutatja be az absztract kulcsszóval olyan osztályokat és metódusokat jelölünk, melyeket nem lehet közvetlenül példányosítani, illetve végrahajtani. Az absztract osztályokat alapként használják más osztályok számára, még az absztract metódusok deklarációkat, de nem adnak impelemntácíókat. 
     Fontos jellemzők:
    - absztract osztály: csak származtatott osztályokon keresztül használható. Tartalmazhat absztract és nem absztract (működő) metódusokat is.
    - absztract metódusok: csak absztract osztályban lehet, és a származtatott osztálynak kötelező megvalósítania.*/
    abstract class Program
    {
        //abstract metódus - nincs implamentáció
        // ennek a kódját a leszármazottban kötelező megírni
        public abstract double GetArea();

        // Normal metódus - van implamentáció

        public void DisplayShape();
        {
            console.writelane("ez egy alakzat);
        }
    }
        class Circle : Shape
        {
            private double suger;

            public Circle(double r)
            {
                this.sugar = r;
            }

            //Abstract metódus implamentálása

            public override double GetArea();
            {
                return Math.PI* sugar;
            }
        }
}
