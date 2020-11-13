using System;

namespace Ejercicio_2_1_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1, numero2;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro.");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if ((numero > numero1) && (numero1> numero2))

                Console.WriteLine("El primer numero es mayor");

            else if ((numero1 > numero) && (numero1 > numero2))

                Console.WriteLine("El segundo numero es mayor");

            if ((numero2 > numero) && (numero2 > numero1))

                Console.WriteLine("El tercer numero es mayor");
        }
    }
}
