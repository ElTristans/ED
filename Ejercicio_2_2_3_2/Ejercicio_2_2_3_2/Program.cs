using System;

namespace Ejercicio_2_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tres = 3;

            for (int contador = 1; contador <= 50; contador++)
            {
                int calculo = contador / tres;
                Console.WriteLine("{0} ", calculo);
            }
        }
    }
}

