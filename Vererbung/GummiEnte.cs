using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    public class GummiEnte : Ente
    {
        //Eigenschaften
        public GummiEnte(string _name) : base(_name) 
        {
            Console.WriteLine(_name);
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
