using System;
using System.Collections.Generic;
using System.Text;

namespace Vererbung
{
    public class Ente
    {
        public string _name;
        private string name;

        public Ente(string name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return _name;
        }
        public virtual void Quacken()
        {
        }
        public virtual void Fliegen()
        {
        }
    }
}
