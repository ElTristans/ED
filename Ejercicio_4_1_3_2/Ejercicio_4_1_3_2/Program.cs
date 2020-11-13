using System;

namespace Ejercicio_4_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int media=0;

            Console.WriteLine("Introduce el total de numeros que vayas a utilizar y sus respectivos valores.");
            total = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[total];

            for (int i = 0; i < total; i++) 
            {
                Console.Write("Introduce el dato numero {0}: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                media += numeros[i];

            }
             media = media / total;
            Console.WriteLine("La media es {0}", media);
        }
    }
}
