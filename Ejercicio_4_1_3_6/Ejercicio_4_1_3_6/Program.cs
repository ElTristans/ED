using System;

namespace Ejercicio_4_1_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_nombres = 10;
            bool nombre_encontrado = false;

            string nombre;

            string[] nombres = new string[total_nombres];

            for (int i = 0; i < total_nombres; i++)
            {
                Console.Write("Introduce el {0}º nombre: ", i + 1);
                nombres[i] = Convert.ToString(Console.ReadLine());
            }
            do
            {
                Console.Write("Introduce el nombre del quieras buscar: ");
                nombre = Convert.ToString(Console.ReadLine());

                for (int j = 0; j < total_nombres; j++)
                {
                    if (nombre == nombres[j])
                    {
                        Console.WriteLine("El nombre {0} si esta", nombre);
                        nombre_encontrado = true;
                        break;
                    }
                }
                    if (nombre_encontrado == false && nombre != "fin")
                    {
                        Console.WriteLine("El nombre {0} no esta", nombre);

                    }
                    nombre_encontrado = false;
                
            } while (nombre != "fin");
        }
    }
}
