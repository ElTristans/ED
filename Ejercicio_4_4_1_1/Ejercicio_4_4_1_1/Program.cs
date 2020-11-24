using System;

namespace Ejercicio_4_4_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            
            Console.WriteLine("Dime tu nombre y te lo repetire 5 veces. ");
            nombre = Console.ReadLine();

            for (int i = 0; i < 5; i++) 
            {
                Console.Write(" {0} ", nombre);
            }
        }
    }
}
