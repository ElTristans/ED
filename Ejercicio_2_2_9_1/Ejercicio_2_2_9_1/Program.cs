using System;

namespace Ejercicio_2_2_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,nueve=9;
         

            Console.Write("Introduce un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            int calculo = numero * nueve;
            Console.WriteLine("{0} * {1} = {2}",numero,nueve,calculo);
        }
    }
}
