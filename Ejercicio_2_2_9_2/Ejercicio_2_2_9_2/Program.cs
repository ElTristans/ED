using System;

namespace Ejercicio_2_2_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero2;

            Console.Write("Introduce un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce un segundo numero:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int calculo;
            for (int i = 1; i <= numero; i++)
            {
                if (i <= numero)
                {
                    calculo = numero % i;

                    if (calculo == 0) {
                        
                        Console.Write(" " + i + " "); }
                }
            }
        }
    }
}
