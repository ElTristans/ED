using System;

namespace Ejercicio_2_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1;

            Console.WriteLine("Introduce un número entero y veremos si es multiplo de 10.");
            numero = Convert.ToInt32(Console.ReadLine());


            if (10 % numero == 1) 
                Console.WriteLine("El primer número es múltiplo de 10.");
            

            Console.WriteLine("Introduce otro número entero para comprobar si es multiplo de 10.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (10 % numero1 == 1) 
                Console.WriteLine("El segundo número es múltiplo de 10.");
        }
    }
}
