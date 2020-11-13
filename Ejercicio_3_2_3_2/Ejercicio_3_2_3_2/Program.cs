using System;

namespace Ejercicio_3_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la distancia en metros. ");
            int distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce las horas");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce las minutos");
            int minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce las segundos");
            int segundos = Convert.ToInt32(Console.ReadLine());

            int ds = distancia / segundos;
            Console.WriteLine("Recores {0} metros en {1} segundos", distancia, ds);

            int kh = distancia / horas;
            Console.WriteLine("Recores {0} kilometros en {1} horas", distancia, kh);

            int milla = 1 / 1609;
            Console.WriteLine("");
        }
    }
}
