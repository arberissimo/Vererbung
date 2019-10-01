using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    class LockEnte : Tier
    {
        //Eigenschaften
        public LockEnte(String name)
        {

        }
        //Methoden
        public override void Quacken()
        {
            Console.WriteLine("Quack");
        }
        public override void Fliegen()
        {
            Console.WriteLine("Fliegen ohne Flügel");
        }
    }
}
