using System;

namespace Ejercicio_3_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long producto = 1000000;
            long resultado;
            resultado = producto * producto;

            Console.WriteLine("Usando long : El producto de {0} * {1} es igual a {2}", producto, producto, resultado);

            int producto1 = 1000000;
            int resultado1;
            resultado1 = producto1 * producto1;

            Console.WriteLine("Usando int : El producto de {0} * {1} es igual a {2}", producto1, producto1, resultado1);
        }
    }
}
