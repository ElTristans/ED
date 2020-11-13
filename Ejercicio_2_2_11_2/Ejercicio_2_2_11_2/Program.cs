using System;

namespace Ejercicio_2_2_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            for (numero = 2; numero <= 106; numero=numero+2)

            {
                if (numero % 10 == 0)
                    continue;

                Console.Write("{0} ", numero);
                Console.WriteLine();
            }
        }
    }
}
