using System;

namespace Ejercicio_1_6_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            int calculo;

            n1 = 233;
            n2 = 567;
            n3 = 333;
            calculo = n1 + n2 * n3;


            Console.WriteLine("el resultado de {0} + {1} * {2} es {3}", n1, n2, n3, calculo);
        }
    }
}
