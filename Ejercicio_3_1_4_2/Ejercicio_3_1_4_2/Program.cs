using System;

namespace Ejercicio_3_1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 5;
            Console.WriteLine("El valor de a es {0}", a);

            b = a+2;
            Console.WriteLine("El valor de b=a+2 es {0}", b);

            b-=3;
            Console.WriteLine("El valor de b-=3 es {0}", b);

            c=-3;
            Console.WriteLine("El valor de c=-3 es {0}", c);

            c *= 2;
            Console.WriteLine("El valor de c*=2 es {0}", c);

            ++c;
            Console.WriteLine("El valor de ++c es {0}", c);

            a*=b;
            Console.WriteLine("El valor de a*=b es {0}", a);
           
        }
    }
}
