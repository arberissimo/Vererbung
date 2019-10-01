using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    class MoorEnte : Tier
    {
        //Eigenschaften
        public MoorEnte(String name)
        {

        }
        //Methoden
        public override void Quacken()
        {
            Console.WriteLine("stummes Quack");
        }
        public override void Fliegen()
        {
            Console.WriteLine("Fliegen ohne Flügel");
        }
    }
}
