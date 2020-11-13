using System;

namespace Ejercicio_2_2_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            for (numero = 20; numero >= 10; numero=numero-2)
            {
                if (numero == 14)
                    continue;
                Console.Write("{0} ", numero);
                Console.WriteLine();
            }
            int n = 20;
            while (n >= 10)
            {
                if (n != 14) //No se puede usar el continue en el bucle while

                    Console.Write("{0} ", n);
                    n=n-2;
                }
            }
                
        }
    }
