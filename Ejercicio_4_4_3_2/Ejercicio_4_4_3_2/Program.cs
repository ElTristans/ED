using System;

namespace Ejercicio_4_4_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Introduce una frase: ");
            nombre = Console.ReadLine();
            

            for (int i = nombre.Length-1; i >= 0; i--)
                Console.Write("{0}", nombre[i]);
        }
    }
}
