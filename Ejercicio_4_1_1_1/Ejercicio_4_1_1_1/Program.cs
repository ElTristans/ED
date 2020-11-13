using System;

namespace Ejercicio_4_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[4];
            double calculo;
            Console.WriteLine("Introduce un primer numero");
            numero[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce un segundo numero");
            numero[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce un tercer numero");
            numero[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce un ultimo numero");
            numero[3] = Convert.ToDouble(Console.ReadLine());

            calculo = (numero[0] + numero[1] + numero[2] + numero[3]) / 4 ;

            Console.WriteLine("La media aritmetica de {0} , {1} , {2} y {3} es {4}",numero[0],numero[1],numero[2],numero[3],calculo);
        }
    }
}
