using System;

namespace Ejercicio_4_4_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string dia;
            string mes;

            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Dime tu dia de nacimiento: ");
            dia = Console.ReadLine();

            Console.WriteLine("Dime tu mes de nacimiento: ");
            mes = Console.ReadLine();

            Console.WriteLine("{0}, nacido el {1}/{2}",nombre,dia,mes);

        }
    }
}
