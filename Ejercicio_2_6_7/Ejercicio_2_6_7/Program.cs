using System;

namespace Ejercicio_2_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un alto:");
            int alto = Convert.ToInt32(Console.ReadLine());

            int ancho = alto;

            int a, l;

            for (a = 1; a <= ancho; a++)
            {
                for (l = 1; l <= alto; l++)
                    Console.Write("*", a);
                Console.WriteLine();
                alto = alto -1;
            }
        }
    }
}
