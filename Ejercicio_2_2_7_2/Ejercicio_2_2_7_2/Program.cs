using System;

namespace Ejercicio_2_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                char letra;
                int bucle;

                for (bucle = 1; bucle <= 5; bucle++)
                {
                    for (letra = 'L'; letra <= 'N'; letra++)
                        Console.Write("{0}", letra);
                }
                        
            }
        }
    }
}