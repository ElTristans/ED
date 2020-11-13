using System;

namespace Ejercicio_2_1_1_3
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

            if (numero % numero1 == 0)
                Console.WriteLine("El primer número es múltiplo del segundo.");

        }
    }
}
