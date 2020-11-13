using System;

namespace Ejercicio_2_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 9;
            Console.WriteLine("Tabla de multiplicacion de 9");

            for (int contador = 1; contador <= 10; contador++)
            {
                int calculo = numero * contador;
                Console.WriteLine("{0} X {1} = {2} ", numero, contador, calculo);
            }
        }
    }
}
