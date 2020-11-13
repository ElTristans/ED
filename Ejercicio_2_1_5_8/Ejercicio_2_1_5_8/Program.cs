using System;

namespace Ejercicio_2_1_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if ((numero > 0) && (numero1 < 0))

                Console.WriteLine("Solo el primer numero es positivo");

            else if ((numero < 0) && (numero1 > 0))

                Console.WriteLine("Solo el segundo numero es positivo");

             if ((numero < 0) && (numero1 < 0))

                Console.WriteLine("Ningun numero es positivo");
        }
    }
}
