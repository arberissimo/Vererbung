using System;

namespace Vererbung
{
    public class Program
    {
       public static void Main(string[] args)
       {
           new Program().Run();
       }

       public void Run()
       {
            GummiEnte gummiente = new GummiEnte("Gummiente");
            gummiente.GetName();
            gummiente.Quacken();
            gummiente.Fliegen();

            LockEnte lockente = new LockEnte("Lockente");
            lockente.GetName();
            lockente.Quacken();
            lockente.Fliegen();

            MoorEnte moorente = new MoorEnte("Moorente");
            moorente.GetName();
            moorente.Quacken();
            moorente.Fliegen();

            StockEnte stockente = new StockEnte("Stockente");
            stockente.GetName();
            stockente.Quacken();
            stockente.Fliegen();

            Console.ReadKey();
       }
    }
}
