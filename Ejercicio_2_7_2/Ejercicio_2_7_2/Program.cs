using System;

namespace Ejercicio_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            try
            {
                Console.WriteLine("Introduce tu edad");
                numero1 = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("No es un número válido");

            int numero2;
                
                Console.WriteLine("Introduce año de nacimiento");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
