using System;

namespace Ejercicio_4_4_5_1
{
    class Program
    {
        static void Main(string[] args)

        {
            const int total_frases = 10;
            string[] frase = new string[total_frases];
            string buscar;
           

            for(int i =0; i<total_frases;i++)
            {
                Console.WriteLine("Escribe la {0}º frase ",i+1);
                frase[i] = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Escribe el texto a buscar ");
                buscar = Console.ReadLine();


                for (int i = 0; i < total_frases; i++)
                {
                    if (frase[i].Contains (buscar))
                        Console.WriteLine("El texto a encontrar aparece en la frase nº{0} ",i+1);
                }
 
            } while (buscar != "fin");
        }
    }
}
