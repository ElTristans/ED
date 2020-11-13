using System;

namespace Ejercicio_3_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero, numero2;

            Console.WriteLine("Introduce dos numeros largos");
            numero = Convert.ToInt16(Console.ReadLine());
            numero2 = Convert.ToInt16(Console.ReadLine());

            long suma =numero + numero2;
            long resta = numero - numero2;
            long producto = numero % numero2;

            Console.WriteLine("La suma de {0} y {1} es igual a {2}", numero, numero2, suma);
            Console.WriteLine("La resta de {0} y {1} es igual a {2}", numero, numero2, resta);
            Console.WriteLine("El producto de {0} y {1} es igual a {2}", numero, numero2, producto);
        }
    }
}
