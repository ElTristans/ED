using System;

namespace Ejercicio_4_4_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char letra;
            bool letra_encontrada = false;

            Console.WriteLine("Introduce una frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Introduce una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == letra)
                letra_encontrada = true;
            }

            if (letra_encontrada == true)
                Console.WriteLine("La letra se encuentra en la frase.");
            else
                Console.WriteLine("La letra no se encuentra dentro de la frase.");
        }
    }
}
