using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    class GummiEnte : Tier
    {
        //Eigenschaften
        public GummiEnte(String name)
        {
          
        }
        //Methoden
        public override void Quacken()
        {
            Console.WriteLine("Quietsch");
        }
        public override void Fliegen()
        {
            Console.WriteLine("Fliegen mit Rakete");
        }
    }
}
