using System;

namespace Ejercicio_2_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, calculo;
            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            
            while (numero != 0)
            {
                calculo = numero * numero;
                if (numero > 0) Console.WriteLine("El cuadrado de {0} es {1}", numero, calculo);
                Console.WriteLine("Introduce otro número: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
