using System;

namespace Ejercicio_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro número entero.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero > numero1)
                Console.WriteLine("El primer número es mayor.");

            if (numero < numero1)
                Console.WriteLine("El segundo número es mayor.");
        }
    }
}
