using System;
using System.Collections.Generic;
using System.Text;

namespace Sternback_Kaffee
{
    public class Entkoffeiniert : Getränk
    {
        //Eigenschaften
        public Entkoffeiniert(string GetBeschreibung, decimal preis) : base(GetBeschreibung, preis)
        {
            Console.WriteLine($"{preis}.-  {GetBeschreibung}");
        }

    }
}
