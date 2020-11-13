using System;

namespace Ejercicio_2_2_6_2
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

            int a, l;

            for (a = 1; a <= ancho; a++)
            {
                for (l = 1; l <= alto; l++)
                    Console.Write("*", a);
                Console.WriteLine();
            }
        }
    }
}
