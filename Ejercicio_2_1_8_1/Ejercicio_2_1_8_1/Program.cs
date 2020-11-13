using System;

namespace Ejercicio_2_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, positivo, negativo;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            positivo = numero > 0 ? positivo : negativo;
            
                Console.WriteLine("El numero es positivo");

            negativo=numero<0 ?
                Console.WriteLine("El numero es negativo y es -{0}", negativo);
        }
    }
}
