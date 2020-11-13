using System;

namespace Ejercicio_2_6_5
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.Write("Introduce un alto:");
            int alto = Convert.ToInt32(Console.ReadLine());

            int ancho = alto;

            int a, l;

            for (a = 1; a <= alto; a++)
            {
                for (l = 1; l <= ancho; l++)
                    Console.Write("*", a);
                Console.WriteLine();
                ancho = ancho - 1;
            }
        }
    }
}

