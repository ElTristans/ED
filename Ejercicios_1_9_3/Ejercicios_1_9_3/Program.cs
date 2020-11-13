using System;

namespace Ejercicios_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;
            int suma;

            Console.WriteLine("Introduce el primer número");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número");
            numero3 = Convert.ToInt32(Console.ReadLine());

            suma = numero1 + numero2 + numero3;

            Console.WriteLine("La suma de {0} , {1} y {2} es {3}", numero1, numero2, numero3, suma);
        }
    }
}
