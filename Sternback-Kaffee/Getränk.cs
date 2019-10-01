using System;
using System.Collections.Generic;
using System.Text;

namespace Sternback_Kaffee
{
    public class Getränk
    {
        public string GetBeschreibung;
        public decimal preis;

        public Getränk(string GetBeschreibung, decimal preis)
        {
            this.GetBeschreibung = GetBeschreibung;
            this.preis = preis;
        }

        public void SetBeschreibung(string GetBeschreibung, decimal preis)
        {
            this.GetBeschreibung = GetBeschreibung;
            this.preis = preis;
        }

        public void GetGetBeschreibung()
        {
            Console.WriteLine(GetBeschreibung);
        }

        public void Getpreis()
        {
            Console.WriteLine(preis);
        }

        public void AddSchokolade(int menge)
        {
            Console.WriteLine(menge * 3 + ".- für Schokolade");

            while (menge >= 0)
            { 
                this.preis += 3;
                menge--;
            }
        }

        public void AddHeisseMilch(int menge)
        {
            Console.WriteLine(menge * 3 + ".- für heisse Milch");

            while (menge >= 0)
            {
                this.preis += 1;
                menge--;
            }
        }

        public void AddSoja(int menge)
        {
            Console.WriteLine(menge * 3 + ".-  für Soja");

            while (menge >= 0)
            {
                this.preis += 2;
                menge--;
            }
        }

        public void AddMilchschaum(int menge)
        {
            Console.WriteLine(menge * 3 + ".- für Milchschaum");

            while (menge >= 0)
            {
                this.preis += 6;
                menge--;
            }
        }

    }
}
