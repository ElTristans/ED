using System;

namespace Ejercicio_3_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero, numero2;

            Console.WriteLine("Introduce dos numeros con un maximo de dos caracteres");
            numero = Convert.ToByte(Console.ReadLine());
            numero2 = Convert.ToByte(Console.ReadLine());

            ushort resultado = Convert.ToUInt16(numero * numero2);

            Console.WriteLine("La multiplicacion de {0} y {1} es igual a {2}", numero, numero2, resultado);
        }
    }
}
