using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    class MoorEnte : Ente
    {
        //Eigenschaften
        public MoorEnte(string _name) : base(_name)
        {
            Console.WriteLine(_name);
        }
        //Methoden
        public override void Quacken()
        {
            Console.WriteLine("stummes Quack");
        }
        public override void Fliegen()
        {
            Console.WriteLine("Fliegen ohne Flügel\n");
        }
    }
}
