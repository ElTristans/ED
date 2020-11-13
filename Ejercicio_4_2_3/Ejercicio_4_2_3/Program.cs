using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] texto; // Array de dos dimensiones
            texto = new int[2][]; //2 bloques

            Console.WriteLine("¿Que valor tendra el primer bloque? : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Que valor tendra el segundo bloque? : ");
            int y = Convert.ToInt32(Console.ReadLine());

            texto[0] = new int[x];
            texto[1] = new int[y];

            for (int i = 0; i < x; i++) //Recorer primer vector
            {
                for (int j = 0; j < y; j++) //Recorer segundo vector
                {
                    Console.Write("Introduce {0} + {1} valores para 2 bloques: ",x,y);
                    texto[i][j]= Convert.ToInt32(Console.ReadLine());
                }

            }
        }
    }
}
