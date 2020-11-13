using System;

namespace Ejercicio_3_2_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double pi = 3.14f;

            Console.WriteLine("Introduce un radio ");
            radio = Convert.ToInt32(Console.ReadLine());

            double volumen = pi * radio * 4/3;

            Console.WriteLine("El area del circulo es {0}", volumen);
        }
    }
}
