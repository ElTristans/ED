using System;
using System.Text;

namespace Ejercicio_4_3_2_1
{
    class Program
    {
        struct tipoCanción
        {
            public string Artista;
            public string Título;
            public int Duración;
            public int Tamanyo;

        }
        static void Main(string[] args)
        {
            int cantidad = 0;
            bool repetir = true;
            bool encontrado = false;
            while (repetir)
            {
                tipoCanción[] cancion = new tipoCanción[100];
                do
                {
                    Console.WriteLine("seleccione una accion a realizar");

                    Console.WriteLine("1) Añadir una nueva cancion ");

                    Console.WriteLine("2) Mostrar el titulo de todas las canciones ");

                    Console.WriteLine("3) Buscar las canciones que contengan un cierto texto (en el artista o titulo) ");

                    int seleccion = int.Parse(Console.ReadLine());


                    switch (seleccion)
                    {

                        case 1:
                            Console.WriteLine("Inserte el nombre de la cancion que quiera añadir: ");
                            cancion[cantidad].Título = Console.ReadLine();

                            Console.WriteLine("Dame el nombre del artista: ");
                            cancion[cantidad].Artista = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Cuanto dura la cancion en segundos: ");
                            cancion[cantidad].Duración = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Cuanto pesa el archivo mp3 en kilobites: ");
                            cancion[cantidad].Tamanyo = Convert.ToInt32(Console.ReadLine());

                            break;

                        case 2:
                            for (int i = 0; i <= cantidad && i < 100; i++)
                                Console.WriteLine("{0}) {1} ", i + 1, cancion[cantidad].Título);

                            break;

                        case 3:

                            Console.WriteLine("Introduce el texto que quieras buscar: ");
                            string texto = Convert.ToString(Console.ReadLine());

                            for (int i = 0; i < cantidad && i < 100; i++)
                            {
                                if (cancion[i].Título == texto || cancion[i].Artista == texto)
                                {
                                    Console.WriteLine("Artista: {0}", cancion[i].Artista);
                                    Console.WriteLine("Título: {0}", cancion[i].Título);
                                    Console.WriteLine("Duración: {0}", cancion[i].Duración);
                                    Console.WriteLine("Tamaño: {0}", cancion[i].Tamanyo);
                                    encontrado = true;

                                    break;
                                }
                                if (encontrado == false)
                                {
                                    Console.WriteLine("La canción no ha sido encontrada.");
                                }
                            }
                            break;
                    }

                } while (seleccion != '3'); 
            }
            }
        }
    }


