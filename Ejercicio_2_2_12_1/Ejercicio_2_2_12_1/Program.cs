using System;

namespace Ejercicio_2_2_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            for (numero = 100; numero <= 200; numero++)
            {
                Console.Write("{0} ", numero);
            }
            int n = 100;
                while (n <= 200)
                {
                    if (n == 200)
                    break;
                    Console.Write("{0} ", n);
                    n++;

                }
            }
        }
    }
