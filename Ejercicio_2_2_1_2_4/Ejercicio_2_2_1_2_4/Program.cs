using System;

namespace Ejercicio_2_2_1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, op;
            Console.WriteLine("Intenta adivinar un número del 1 al 10: ");
            n = Convert.ToInt32(Console.ReadLine());
            op = 0;


            if (n == 4)
            {
                Console.WriteLine("Felicidades has acertado");
            }
            while (n != 4)
            { 
                Console.WriteLine("Has fallado, vuele a intentarlo");
                op = op + 1;
                
            if (op <= 3) 

                Console.WriteLine("Lo siento te has quedado sin oportunidades.");
            }
            
        }
    }
}
