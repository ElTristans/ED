using System;

namespace Ejercicio_4_1_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int mes, dia;
            int dia_anio = 0;

            Console.WriteLine("Introduce el mes (1 = enero, 12 = diciembre)");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el dia");
            dia = Convert.ToInt32(Console.ReadLine());
            mes--;

            for (int i = 0; i < mes; i++)
            {
                dia_anio = dia_anio + meses[i];
            }
            dia_anio += dia;

            dia_anio = 365 - dia_anio;

            Console.WriteLine("Quedan {0} dias hasta final de año", dia_anio);
        }
    }
}
