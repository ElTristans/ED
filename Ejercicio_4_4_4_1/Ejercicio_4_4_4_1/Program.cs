using System;

namespace Ejercicio_4_4_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string subcadena;
            int j = 1;

            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                subcadena = nombre.Substring(i, j);
                Console.Write("{0} ", subcadena);
                j++;
            }
        }
    }
}
