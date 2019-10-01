using System;

namespace Sternback_Kaffee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            DunkelGeröstet dunkelgeröstet = new DunkelGeröstet("Dunkelgeröstet", 5);
            dunkelgeröstet.AddSchokolade(8);

            Console.WriteLine("........................................................");

            Entkoffeiniert entkoffeiniert = new Entkoffeiniert("Entkoffeiniert", 6);
            entkoffeiniert.AddSoja(3);

            Console.WriteLine("........................................................");

            Espresso espresso = new Espresso("Espresso", 7);
            espresso.AddHeisseMilch(7);

            Console.WriteLine("........................................................");

            Hausmischung hausmischung = new Hausmischung("Hausmischung", 4);
            entkoffeiniert.AddMilchschaum(6);
        }
    }
}
