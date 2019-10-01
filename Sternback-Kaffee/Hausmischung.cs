using System;
using System.Collections.Generic;
using System.Text;

namespace Sternback_Kaffee
{
    public class Hausmischung : Getränk
    {
        //Eigenschaften
        public Hausmischung(string GetBeschreibung, decimal preis) : base(GetBeschreibung, preis)
        {
            Console.WriteLine($"{preis}.-  {GetBeschreibung}");
        }
    }
}
