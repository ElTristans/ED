using System;

namespace Ejercicio_1_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int calculo;

            numero2 = 1852; 

            Console.WriteLine("Introduce una cantidad de millas náutica y te muestro la equivalencia en metros");
            numero1 = Convert.ToInt32(Console.ReadLine());

            calculo = numero1 * numero2;

            Console.WriteLine("La equivalencia de {0} millas náuticas es igual a {2} en metros", numero1, numero2, calculo);
        }
    }
}
