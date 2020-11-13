using System;

namespace Ejercicio_4_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz=new int[2,2]; // Array de dos dimensiones

            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Introduce valor para [{0},{1}]: ",i+1,j+1);
                    matriz[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int det = matriz[0, 0] * matriz[1, 1] - (matriz[0, 1] * matriz[1, 0]);
            Console.WriteLine("El resultado es: {0}",det);


        }
    }
}
