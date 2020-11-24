using System;

namespace Ejercicio_4_4_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string subcadena;
           

            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();

            for (int i = 1; i <=nombre.Length; i++) 
            {
                subcadena = nombre.Substring(0, i);
                Console.WriteLine("{0} ", subcadena);
                
            }
        }
    }
}
