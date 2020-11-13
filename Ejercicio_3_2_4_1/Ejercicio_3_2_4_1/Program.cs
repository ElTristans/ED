using System;

namespace Ejercicio_3_2_4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce un numero");
            double numero = Convert.ToDouble(Console.ReadLine());

            double calculo;
            resultado = Math.Sqrt(numero);

            Console.WriteLine("La raiz cuadrada de {0} es igual a {1}", numero,resultado);
        }
    }
}

