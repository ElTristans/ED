using System;

namespace Ejercicio_3_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            float pi = 3.14f;

            Console.WriteLine("Introduce el radio de un circulo y te doy su area");
            radio = Convert.ToInt32(Console.ReadLine());

            float area = pi * radio;

            Console.WriteLine("El area del circulo es {0}",area);
            
        }
    }
}
