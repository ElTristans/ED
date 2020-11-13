using System;

namespace Ejercicio_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int producto;

            Console.WriteLine("Introduce el primer número");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());

            producto = numero1 + numero2;

            Console.WriteLine("El producto de {0} y {1} es {2}", numero1, numero2, producto);
            
        }
    }
}
