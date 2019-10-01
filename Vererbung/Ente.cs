using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    public class Ente
    {
        public string _name;
        public string name;

        public Ente(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
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
            Console.WriteLine("Fliegen mit Flügel\n");
        }
    }
}
