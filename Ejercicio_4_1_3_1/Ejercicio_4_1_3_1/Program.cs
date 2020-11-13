using System;

namespace Ejercicio_4_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[6];
            int i;

            Console.WriteLine("Introduce un primer numero");
            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un segundo numero");
            numero[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un tercer numero");
            numero[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un cuarto numero");
            numero[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un quinto numero");
            numero[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un sexto numero");
            numero[5] = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < 6; i++)
                i += numero[0];
            Console.WriteLine("{0} , {1} , {2} , {3} , {4}, {5}", numero[5], numero[4], numero[3], numero[2], numero[1], numero[0]);

        }
    }
}
