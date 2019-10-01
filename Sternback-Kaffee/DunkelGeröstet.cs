using System;
using System.Collections.Generic;
using System.Text;

namespace Sternback_Kaffee
{
    public class DunkelGeröstet : Getränk
    {
        //Eigenschaften
        public DunkelGeröstet(string GetBeschreibung, decimal preis) : base(GetBeschreibung, preis)
        {
            Console.WriteLine($"{preis}.-  {GetBeschreibung}");
        }
    }
}
