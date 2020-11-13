using System;

namespace Ejercicio_1_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, operacion1, operacion2;

            Console.Write("Introduce el primer número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            operacion1 = (a + b) * (a - b);
            operacion2 = a^2 - b^2;

            Console.Write("El resultado de la operacion1 es ");
            Console.Write(operacion1);
            Console.Write(" Y el resultado de la operacion2 es ");
            Console.Write(operacion2);

        }
    }
}
