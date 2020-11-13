using System;

namespace Ejercicio_2_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            do
            {
                Console.Write("Escriba un numero positivo:");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba otro numero positivo:");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 + numero2;
                if (numero1 != 0 || numero2 != 0)
                    
                    Console.WriteLine("El resultado es {0}", resultado);

            } while (numero1 != 0 && numero2 != 0);
            Console.WriteLine("Haga click para salir del programa...");
        }
    }
}
