using System;

namespace Ejercicio_2_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Escribe una contraseña: ");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero != 1111) 
            {
                if (numero != 1111) Console.WriteLine("Es incorrecto");
                Console.WriteLine("Vuelve a intentarlo: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
