using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    class StockEnte : Ente
    {
        //Eigenschaften
        public StockEnte(string _name) : base(_name)
        {
            Console.WriteLine(_name);
        }
            
        //Methoden
        public override void Quacken()
        {
            Console.WriteLine("Quack");
        }
        public override void Fliegen()
        {
            Console.WriteLine("Fliegen mit Flügel\n");
        }
    }
}
