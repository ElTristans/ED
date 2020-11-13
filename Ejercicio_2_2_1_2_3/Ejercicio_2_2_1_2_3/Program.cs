using System;

namespace Ejercicio_2_2_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contador;
            Console.WriteLine("Dame un número: ");
            n = Convert.ToInt32(Console.ReadLine());
            contador = 0;

            while (n > 0)
            {
                Console.WriteLine(n);
                n = n / 10;

                contador = contador + 1;
            }
            Console.WriteLine("El numero de cifras es {0}", contador);
        }

    }
}
