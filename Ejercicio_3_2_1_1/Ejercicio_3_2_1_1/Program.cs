using System;

namespace Ejercicio_3_2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4;
            float c = a / b;
            Console.WriteLine("El resultado de dividir {0} entre {1} usando numeros enteros es {2}", a, b, c);


            float n = 3, m = 4;
            float o = n / m;
            Console.WriteLine("El resultado de dividir {0} entre {1} usando numeros de coma flotante es {2}", n, m, o);
        }
    }
}
