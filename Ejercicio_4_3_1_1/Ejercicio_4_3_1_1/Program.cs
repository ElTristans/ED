using System;

namespace Ejercicio_4_3_1_1
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
            tipoCanción cancion;

                Console.WriteLine("Dame el nombre del artista: ");
                cancion.Artista = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Dime el título de la canción: ");
                cancion.Título = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Cuanto dura la cancion en segundos: ");
                cancion.Duración = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cuanto pesa el archivo mp3 en kilobites: ");
                cancion.Tamanyo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El nombre de la cancion es {1} siendo su artista {0} con una duración de {2} segundos y pesa {3} KB.", cancion.Artista, cancion.Título, cancion.Duración, cancion.Tamanyo);
            
        }
    }
}
