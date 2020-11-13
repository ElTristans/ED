using System;

namespace Ejercicio_3_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13, b = 6;
            float c = a / b;
            Console.WriteLine("El resultado de dividir {0} entre {1} usando numeros enteros es {2}", a, b, c);


            float n = 13, m = 6;
            float o = n / m;
            Console.WriteLine("El resultado de dividir {0} entre {1} usando numeros de coma flotante es {2}", n, m, o);

            double r = 13, s = 6;
            double t = n / m;
            Console.WriteLine("El resultado de dividir {0} entre {1} usando numeros de doble precisión es {2}", r, s, t);

        }
    }
}
