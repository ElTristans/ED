using System;

namespace Ejercicio_2_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero%3==0)  
                Console.WriteLine("El numero introducido es múltiplo de 3 ");
            else
                Console.WriteLine("El numero introducido es múltiplo de 2 ");
        }
    }
}
