using System;

namespace Ejercicio_2_6_6
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

            for (a = 1; a <= alto; a++)
            {
                for (l = 1; l <= ancho; l++)
                
                    if (l == 1 || l == ancho || a == 1 || a == ancho
                    Console.Write("*");
                
                    else {
                        Console.Write(" ");
                        Console.WriteLine();

                    }
            }

        }
    }
}
