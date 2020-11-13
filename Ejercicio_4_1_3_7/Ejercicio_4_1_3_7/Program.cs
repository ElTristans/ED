using System;

namespace Ejercicio_4_1_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            string nombre = "";
            int nombresLeidos = 0;

            Console.WriteLine("Introduce un nombre (vacio para salir):");
            nombre = Console.ReadLine();

                while ((nombre != "") && (nombresLeidos < 100))
                {
                    nombres[nombresLeidos] = nombre;

                nombresLeidos++;

                    Console.Write("Introduce un nombre vacio para salir):");
                    nombre = Console.ReadLine();
                }

            for (int j = 0; j < nombresLeidos; j++) 
            Console.WriteLine(nombres[j]);
        } 
    }
}
