using System;

namespace Ejercicio_3_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Introduzca un numero");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0)
                {
                    Console.Write("El resultado en binario es : "); Console.WriteLine(Convert.ToString(numero, 2));
                    Console.Write("El resultado en hexadecimal es : "); Console.WriteLine(Convert.ToString(numero, 16));
                }
            }

            while (numero != 0); 

            Console.WriteLine("Has introducido un 0");
            
        }
    }
}
