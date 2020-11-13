using System;

namespace Ejercicio4_3_2_2
{
    class Program
    {
        struct tipoImagen
        {
            public string nombre;
            public int ancho;
            public int alto;
            public float tamanyo;
            static void Main(string[] args)
            {
                tipoImagen[] imagen = new tipoImagen[700];
                char opcion;
                int total = 0;

                do
                {
                    Console.WriteLine("1. Añadir una nueva ficha");
                    Console.WriteLine("2. Ver todas las ficha·");
                    Console.WriteLine("3. Buscar una ficha mediante texto");
                    opcion = Convert.ToChar(Console.ReadLine());

                    switch (opcion)
                    {
                        case '1':

                            Console.Write("Introduce el nombre de la imagen: ");
                            imagen[total].nombre = Convert.ToString(Console.ReadLine());
                            Console.Write("Introduce el ancho de la imagen: ");
                            imagen[total].ancho = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduce el alto de la imagen: ");
                            imagen[total].alto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduce el tamaño de la imagen: ");
                            imagen[total].tamanyo = Convert.ToSingle(Console.ReadLine());

                            total++;

                            if (total == 700)
                                Console.WriteLine("Has sobrepasado el limite de 700 canciones.");

                            break;


                        case '2':

                            for (int i = 0; i < total && i < 700; i++)
                            {
                                Console.WriteLine("Nombre : {0} ", imagen[i].nombre);
                                Console.WriteLine("Ancho : {0} ", imagen[i].ancho);
                                Console.WriteLine("Alto : {0} ", imagen[i].alto);
                                Console.WriteLine("Tamaño : {0} ", imagen[i].tamanyo);
                            }
                            break;



                        case '3':
                            Console.Write("Introduce el nombre de la imagen a buscar: ");
                            string buscar = Convert.ToString(Console.ReadLine());

                            for (int i = 0; i < total && i < 700; i++)
                            {
                                if ((i + 1) == buscar || buscar == imagen[i].nombre))
                                    {
                                    Console.WriteLine("Nombre : {0} ", imagen[i].nombre);
                                    Console.WriteLine("Ancho : {0} ", imagen[i].ancho);
                                    Console.WriteLine("Alto : {0} ", imagen[i].alto);
                                    Console.WriteLine("Tamaño : {0} ", imagen[i].tamanyo);

                                    break;
                                } 
                            }
                    }
                } while


            }
        }
    }
}
