
using System;
using System.Collections.Generic;
using System.Text;

namespace Sternback_Kaffee
{
    public class Espresso : Getränk
    {
        //Eigenschaften
        public Espresso(string GetBeschreibung, decimal preis) : base(GetBeschreibung, preis)
        {
            Console.WriteLine($"{preis}.-  {GetBeschreibung}");
        }

    }
}
