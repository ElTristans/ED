using System;

namespace Ejercicio_2_1_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2 == 0) && !(numero1 % 2 == 0))
            
                Console.WriteLine("Solo el primer numero es par");
            
            else if (!(numero % 2 == 0) && (numero1 % 2 == 0))
            
                Console.WriteLine("Solo el segundo numero es par");
            
        }
    }
}
