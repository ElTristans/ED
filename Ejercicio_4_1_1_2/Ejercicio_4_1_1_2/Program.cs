using System;

namespace Ejercicio_4_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numero = new float[5];

            Console.WriteLine("Introduce un primer numero");
            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un segundo numero");
            numero[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un tercer numero");
            numero[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un cuarto numero");
            numero[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un ultimo numero");
            numero[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} , {1} , {2} , {3} , {4}", numero[4], numero[3], numero[2], numero[1], numero[0] );
        }
    }
}
