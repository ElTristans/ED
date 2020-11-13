using System;

namespace Ejercicio_2_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1, dividir;

            Console.WriteLine("Introduce un primer número entero.");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un segundo número entero.");
            numero1 = Convert.ToInt32(Console.ReadLine());
     
            if (numero1 == 0)
                Console.WriteLine("Error: No se puede dividir entre cero");

            dividir = numero / numero1;
            Console.WriteLine("El resultado de la division de los dos numeros es {0}.",dividir);
           

        }
    }
}
