using System;

namespace Ejercicio_4_4_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();
            int longitud = nombre.Length;

            for (int i = 0; i < longitud; i++)
                Console.Write("{0} ", nombre[i]);
        }
    }
}
