using System;

namespace Ejercicio_2_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1, producto;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 0)
                Console.WriteLine("El producto de 0 por cualquier número es 0");

            else
                Console.WriteLine("Introduce un segundo número y te mostrare el producto de ambos.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            producto = numero * numero1;

            Console.WriteLine("El resultado del producto de {0} y {1} es {2}", numero, numero1, producto);
        }
    }
}
