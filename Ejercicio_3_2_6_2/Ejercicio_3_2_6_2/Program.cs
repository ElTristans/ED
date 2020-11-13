using System;

namespace Ejercicio_3_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rojo, verde, azul;

                Console.WriteLine("Introduzca un valor para rojo");
                rojo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca un valor para verde");
                verde = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca un valor para azul");
                azul = Convert.ToInt32(Console.ReadLine());

            int colores = azul + verde + rojo;

            Console.Write("El resultado en hexadecimal es : "); Console.WriteLine(Convert.ToString(colores, 16));
        }
    }
}
