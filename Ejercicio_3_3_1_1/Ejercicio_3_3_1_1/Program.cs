using System;

namespace Ejercicio_3_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Introduzca una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            if (letra == 'a' || letra == 'A' ||
                 letra == 'e' || letra == 'E' ||
                 letra == 'i' || letra == 'I' ||
                 letra == 'o' || letra == 'O' ||
                 letra == 'a' || letra == 'U')
                Console.WriteLine("Es una vocal");

            else
               Console.WriteLine("No es una vocal");
        }
    }
}
