using System;

namespace Ejercicio_4_1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 10;
            int media = 0;

            int[] numeros = new int[total];

            for (int i = 0; i < total; i++)
            {
                Console.Write("Introduce el dato numero {0}: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                media += numeros[i];

            }
            media = media / total;
            Console.WriteLine("La media es {0}", media);

            foreach (var value in numeros)
            {
                if (value > media)
                {
                    Console.WriteLine("Los numeros mayores al promedio son: " + value);
                }
            }
        }
    }
}



