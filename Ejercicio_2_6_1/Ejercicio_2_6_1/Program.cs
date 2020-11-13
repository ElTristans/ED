using System;

namespace Ejercicio_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int valor=87, numero;
                int intentos = 6;

                Console.WriteLine("Adivina un número entre 1 y 100. Tienes {0} intentos", intentos);
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                while ((numero != valor) && (intentos > 1))
                {
                    intentos = intentos - 1;

                    if (numero < valor)
                        Console.WriteLine("Te has quedado corto");

                    if (numero > valor)
                        Console.WriteLine("Te has pasado");

                    Console.WriteLine("Te quedan {0} intentos", intentos);
                    Console.Write("Introduce un número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

                if (numero == valor)
                    Console.WriteLine("Has acertado");
                else
                {
                    Console.WriteLine("Has fallado, era el {0} ",valor);
                }
            }
        }

    }
}

