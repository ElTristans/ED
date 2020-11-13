using System;

namespace Ejercicio_4_1_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5; // Capacidad maxima del array
            int cantidad = 3; // Número real de datos guardados
            int i; // Para recorrer los elementos
            int valor;

            // Mostramos el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();


                Console.WriteLine("Introduce la posicion del valor que quieras eliminar");
                int posi = Convert.ToInt32(Console.ReadLine());

            if (posi > 3)
                Console.WriteLine("La posicion escogida no es valida.");

            else
            {
                Console.WriteLine("Borrando el dato de la {0}º posicion", posi);
                int posicion = posi - 1;
                for (i = posicion; i < cantidad - 1; i++)
                    datos[i] = datos[i + 1];
                cantidad--;
            }


            // Mostramos el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();

        }
    }
}
