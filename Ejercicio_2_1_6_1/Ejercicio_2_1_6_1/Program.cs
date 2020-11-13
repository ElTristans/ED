using System;

namespace Ejercicio_2_1_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 0)

            Console.WriteLine("El número es cero.");
            else 
                if (numero < 0)
                Console.WriteLine("El número es negativo.");
                else
                Console.WriteLine("El número es positivo.");

        }
    }
}
