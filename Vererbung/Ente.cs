using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    class Ente
    {
        private string _name;

        public Ente(string name)
        {
            _name = name;
        }

        public String GetName()
        {
            return _name;
        }

        public virtual void Quacken()
        {
            Console.WriteLine("Quack");
        }
        public virtual void Fliegen()
        {
            Console.WriteLine("Fliegen mit Flügel");
        }
    }
}
