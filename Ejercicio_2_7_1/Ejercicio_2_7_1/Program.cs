using System;

namespace Ejercicio_2_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            try
            {
                Console.WriteLine("Introduce tu edad: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce tu año de nacimiento: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
               
            }

            catch (FormatException)
            {
                Console.WriteLine("No es un número válido");
            }

        }
    }
}
