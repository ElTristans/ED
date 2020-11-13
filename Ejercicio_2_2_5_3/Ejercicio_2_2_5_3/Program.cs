using System;

namespace Ejercicio_2_2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            for (n = 10; n <= 20; n++)
            {
                if (n % 5 == 0) Console.WriteLine("{0} es divisible entre 5", n);
                if (n % 6 == 0) Console.WriteLine("{0} es divisible entre 6", n);
                if (n % 7 == 0) Console.WriteLine("{0} es divisible entre 7", n);
            }
        }
    }
}
