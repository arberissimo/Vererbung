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
            GummiEnte gummiente = new GummiEnte();

            gummiente._name = "Gummiente";
            gummiente.Quacken();
            gummiente.Fliegen();

            Console.ReadKey();
       }
    }
}
