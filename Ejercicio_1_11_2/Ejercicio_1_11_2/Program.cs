using System;

namespace Ejercicio_1_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;

            Console.Write("Introduce el primer número: ");
            a = Convert.ToInt32(Console.ReadLine());

            x1 = a * 1;
            x2 = a * 2;
            x3 = a * 3;
            x4 = a * 4;
            x5 = a * 5;
            x6 = a * 6;
            x7 = a * 7;
            x8 = a * 8;
            x9 = a * 9;
            x10 = a * 10;

            Console.Write("La tabla de multiplicar de {0} es {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} ", a, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);


        }
    }
}
