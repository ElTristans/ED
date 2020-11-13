using System;
using System.Diagnostics;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero = 0;

            numero = Convert.ToInt32(Console.ReadLine());

            Stopwatch cronometro = Stopwatch.StartNew();
            cronometro.Start();

            for (int i = 0; i <= numero; i++) ;

            cronometro.Stop();

            Console.WriteLine("Tiempo: " + cronometro.Elapsed.TotalMilliseconds);

        }
    }
}
