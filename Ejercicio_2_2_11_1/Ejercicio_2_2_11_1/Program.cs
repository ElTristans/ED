using System;

namespace Ejercicio_2_2_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            for (numero = 20; numero >= 10; numero--)

            {
                if (numero == 13)
                    continue;

                Console.Write("{0} ", numero);
                Console.WriteLine();
            }
        }
    }
}
