using System;

namespace Ejercicio_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int frase;
            Console.Write("Introduce una frase: ");
            frase = Convert.ToInt32(Console.ReadLine());

            string cadena = "frase";
            char aBuscar = 'a';
            int n = 0;
            foreach (char a in cadena)
            {
                if (a == aBuscar) ++n;

            }
        }
    }
}
