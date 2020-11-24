using System;

namespace EjercicioPrueba_4_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            string palabra = "";
            int posicion=0;
            int longitud=0;

            Console.WriteLine("Frase:");
            frase = Console.ReadLine();

            Console.WriteLine("palabra:");
            palabra = Console.ReadLine();

            posicion = frase.IndexOf(palabra);
            longitud = palabra.Length;

            while (posicion != -1)
            {
                frase = frase.Remove(posicion, longitud);
                posicion = frase.IndexOf(palabra);
            }
            Console.WriteLine(frase);
        }
    }
}
