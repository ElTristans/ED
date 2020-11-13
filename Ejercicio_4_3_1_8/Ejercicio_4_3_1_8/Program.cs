using System;

namespace Ejercicio_4_3_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[3];
            double modulo = 0;

            for (int i= 0; i < 3; i++)
            {
                Console.Write("Componente {0}", i + 1);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            modulo = Math.Sqrt(Math.Pow(vector[0], 2) +     // (Vector[0] * vector[0] +
                               Math.Pow(vector[1], 2) +     //  vector[1] * vector[1] +
                               Math.Pow(vector[2], 2));     //  vector[2] * vector[2]) 

            Console.WriteLine("El módulo es {0}", modulo);

        }
    }
}
