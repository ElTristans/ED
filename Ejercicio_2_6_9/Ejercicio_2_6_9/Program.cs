using System;

namespace Ejercicio_2_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, col, row;

            do//Con este do while + if evitamos que inserte un valor mayor de 9 y se lo comunicamos al usuario.
            {
                Console.Write("Introduce un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 9)
                {
                    Console.WriteLine("No puedes introducir un valor superior al 9.");
                }
            } while (num > 9);

            for (col = 1; col <= num; col++)//Dos for para hacer el rectangulo uno define la columna y otro la fila
            {
                for (row = 0; row < num; row++)
                {
                    Console.Write(col);//como el valor que pide coincide con el numero de columna podemos aprovecharlo
                }
                Console.WriteLine();
            }
        }
    }
}
