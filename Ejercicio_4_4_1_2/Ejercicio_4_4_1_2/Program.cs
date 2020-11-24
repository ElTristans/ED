using System;

namespace Ejercicio_4_4_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            

            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();

            if (nombre == "tristan")
            
                Console.WriteLine("Bienvenido jefe");

            else 

                Console.WriteLine("Bienvenido {0}",nombre);
        }
    }
}
