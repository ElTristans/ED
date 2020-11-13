using System;

namespace Ejercicio_4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] texto; // Array de dos dimensiones
            texto = new string[2][]; //2 bloques
            texto[0] = new string[6]; //  Cadena de 6
            texto[1] = new string[6];

            for (int i = 0; i < 2; i++) //Recorer primer vector
            {
                for (int j = 0; j < 6; j++) //Recorer segundo vector
                {
                    Console.Write("Introduce 6 textos para 2 bloques: ");
                    texto[i][j] = Convert.ToString(Console.ReadLine());
                }


            }
        }
    }
}