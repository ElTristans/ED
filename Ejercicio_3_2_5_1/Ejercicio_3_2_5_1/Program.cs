using System;

namespace Ejercicio_3_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,numero2;

            Console.WriteLine("Introduce un numero de hasta 12 cifras");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un segundo numero de hasta 12 cifras");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int calculo = numero / numero2;

            Console.WriteLine("El resultado de divir {0} y {1} es igual a {2}",numero,numero2,calculo);
        }
    } 
}
