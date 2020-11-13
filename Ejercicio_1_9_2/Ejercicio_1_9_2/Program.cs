using System;

namespace Ejercicio_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int division;
            int resto;

            Console.WriteLine("Introduce el primer número");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());

            division = numero1 / numero2;
            resto = numero1 % numero2;

            Console.WriteLine("La division de {0} y {1} es {2} y el resto es {3}", numero1, numero2, division, resto);
        }
    }
}
