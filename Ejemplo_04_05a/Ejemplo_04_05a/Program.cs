using System;

namespace Ejemplo_04_05a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diasMes = { 31, 28, 21 };
            foreach (int dias in diasMes)
            {
                Console.WriteLine("Dias del mes: {0}", dias);
            }
            for (int i = 0; i < diasMes.Length; i++)
            {
                Console.WriteLine("1) Dias del mes: {0}", diasMes[i]);
            }
            Console.WriteLine();

            string[] nombres = { "Alberto", "Andrés", "Antonio" };
            foreach (string nombre in nombres)
            {
                Console.Write(" {0}", nombre);
            }
            for (int j = 0; j < nombres.Length; j++)
            {
                Console.Write(" 1) {0}", nombres[j]);
            }
            Console.WriteLine();

            string saludo = "Hola";
            foreach (char letra in saludo)
            {
                Console.Write("{0}-", letra);
            }
            for (int k = 0; k < saludo.Length; k++)
            {
                Console.Write("1) {0}-", saludo[k]);
            }
            Console.WriteLine();
        }
    }
}
