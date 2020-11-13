using System;

namespace Ejercicio_3_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");
            byte edad=Convert.ToByte(Console.ReadLine());

            Console.WriteLine("No aparentas tener {0} años", edad);
        }
    }
}
