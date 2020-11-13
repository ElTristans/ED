using System;

namespace Ejercicio4_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAXIMO = 11; 

            string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

            char texto;

            Console.WriteLine("Como deseas ver los meses s/n");
            texto=Convert.ToChar(Console.Read());

            if (texto == 's')
            {
                for (int i = 0; i <= MAXIMO; i++)
                {
                    Console.WriteLine("{0}", meses[i]);
                }
            }
            else

                for (int i = MAXIMO; i >= 0; i--)
                {
                    Console.WriteLine("{0}", meses[i]);
                }
        }
    }
}
