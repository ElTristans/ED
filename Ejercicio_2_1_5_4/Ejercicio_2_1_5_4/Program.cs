using System;

namespace Ejercicio_2_1_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2 == 0) || !(numero % 3 == 0))
                Console.WriteLine("El numero introducido es no es multiplo ni de 2 ni de 3");
        }
    }
}
