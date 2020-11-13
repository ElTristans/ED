using System;

namespace Ejercicio_2_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = -1;
            int numero1 = -1;


            while ((numero != 0) || (numero1 != 0))
            {
                Console.Write("Introduce un primer número:");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduce un segundo número:");
                numero1 = Convert.ToInt32(Console.ReadLine());

                if (numero % numero1 == 0)
                    Console.WriteLine("{0} es múltiplo de {1}", numero, numero1);
            }
        }
    }
}
