using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    public class LockEnte : Ente
    {
        //Eigenschaften
        public LockEnte(string _name) : base(_name)
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
            Console.WriteLine("Fliegen ohne Flügel");
        }
    }
}
