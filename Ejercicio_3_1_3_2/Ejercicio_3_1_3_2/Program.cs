using System;

namespace Ejercicio_3_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 5;
            Console.WriteLine("El resultado de la operacion de a es {0}", a);
            b = ++a;
            Console.WriteLine("El resultado de la operacion de b es {0}", b);
            c = a++;
            Console.WriteLine("El resultado de la operacion de c es {0}", c);

            b = b * 5;
            Console.WriteLine("El resultado de la operacion de b * 5 es {0}", b);
            a = a * 2;
            Console.WriteLine("El resultado de la operacion de a * 2 es {0}", a);
        }
    }
}
