using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    class StockEnte : Tier
    {
        //Eigenschaften
        public StockEnte(String name)
        {

        }
        //Methoden
        public override void Quacken()
        {
            Console.WriteLine("Quack");
        }
        public override void Fliegen()
        {
            Console.WriteLine("Fliegen mit Flügel");
        }
    }
}
