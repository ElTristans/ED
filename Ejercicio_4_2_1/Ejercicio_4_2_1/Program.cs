using System;

namespace Ejercicio_4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numero; // Array de dos dimensiones
            numero = new int[2][]; //2 bloques
            numero[0] = new int[10];
            numero[1] = new int[10];
            int mayor[0];

            for (int i = 0; i < 2; i++) //Recorer primer vector
            {
                for (int j = 0; j < 10; j++) //Recorer segundo vector
                {
                    Console.Write("Introduce 20 valores para 2 bloques: ");
                    numero[i][j] = Convert.ToInt32(Console.ReadLine());
                }

                if (numero > 
                
            }
        }
    }
}
