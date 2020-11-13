using System;

namespace Ejercicio_2_2_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho, alto;

            Console.Write("Introduce un ancho:");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un alto:");
            alto = Convert.ToInt32(Console.ReadLine());

            int filaActual, columnaActual;

            for (filaActual = 1; filaActual <= ancho; filaActual++)
            {
                for (columnaActual = 1; columnaActual <= alto; columnaActual++)
                    Console.Write("*", filaActual);
                Console.WriteLine();
            }
        }
    }
}
