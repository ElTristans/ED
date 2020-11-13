using System;

namespace Ejercicio_2_1_5_10
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

            if ((numero == numero1) && (numero1 == numero))

                Console.WriteLine("Los numeros son iguales");

            else if ((numero > numero1) && (numero > numero1))

                Console.WriteLine("El primer numero es mayor");

            if ((numero1 > numero) && (numero1 > numero))

                Console.WriteLine("El segundo numero es mayor");
        }
    }
}
