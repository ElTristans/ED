using System;

namespace Ejercicio_3_3_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce el alto");
            int alto = int.Parse(Console.ReadLine());

            Console.WriteLine("introduce el ancho");
            int ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("introduce una letra");
            char letra = char.Parse(Console.ReadLine());

            int i, j;
            for (i = 1; i <= alto; i++) 
            {
                for (j = 1; j <= ancho; j++) 
                    Console.Write("{0}", letra);
                Console.WriteLine(" ");
            }

        }
    }
}
